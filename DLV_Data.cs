using System;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;

using DLV_DL5;

namespace moneys4_dl5 {
    class DLV_Data {
        private S5Data data;
        private string input;
        private string output;

        public DLV_Data(string input, string output) {
            this.input = input;
            this.output = output;        
            Deserialize(input);
        }

        private void Deserialize(string input) {
            var serializer = new XmlSerializer(typeof(S5Data));

            using (var stringReader = new StringReader(File.ReadAllText(input))) {
                data = (S5Data)serializer.Deserialize(stringReader);
            }
        }

        public void createDL5Files() {
            if(data == null || data.DodaciListVydanyList == null) throw new Exception("Chybný XML soubor.");

            int resultI = 0; float resultF = 0;

            foreach(S5DataDodaciListVydany dl in data.DodaciListVydanyList) {
                DL5 dl5 = new DL5() {
                    IcDodavatele = dl.MojeFirma.IC,
                    OznaceniDl = dl.CisloDokladu,
                    IcOdberatele = dl.Adresa.Firma.ICO,
                    CisloObjednavky = int.TryParse(dl.Odkaz, out resultI) ? resultI : null,
                    KodovaStranka = 1250,
                    PocetPolozek = int.TryParse(dl.PocetPolozek, out resultI) ? resultI : null,
                    SoucetBezDph = float.TryParse(dl.Suma.Zaklad, out resultF) ? resultF : null,
                    SoucetSDph = float.TryParse(dl.Suma.Celkem, out resultF) ? resultF : null,
                    SoucetBezDphSazba1 = null,
                    SoucetSDphSazba1 = null, 
                    SoucetBezDphSazba2 = null, 
                    SoucetSDphSazba2 = null, 
                    IdSkladu = null
                };

                foreach(S5DataDodaciListVydanyPolozkyPolozkaDodacihoListuVydaneho pol in dl.Polozky.PolozkaDodacihoListuVydaneho) {
                    DL5_item dl5i = new DL5_item() {
                        Kod = null,
                        Nazev = pol.ObsahPolozky.Artikl.Nazev,
                        Skupina = null, 
                        Dph = float.TryParse(pol.DPH.Sazba, out resultF) ? resultF : null,
                        VyrobCena = null, 
                        NakupCenaSDph = null, 
                        ProdejCenaSDph = null, 
                        Mnozstvi = float.TryParse(pol.Mnozstvi, out resultF) ? resultF : null,
                        Sarze = null, 
                        Expirace = null, 
                        CarovyKod = null, 
                        KodDodavatele = pol.ObsahPolozky.Artikl.Kod,
                        DruhKodu = 0,
                        NakupniCenaBezDph = float.TryParse(pol.JednCena, out resultF) ? resultF : null,
                        Certifikat = null
                    };

                    dl5i.NakupCenaSDph = dl5i.NakupniCenaBezDph * (1 + (dl5i.Dph/100));

                    dl5.Polozky.Add(dl5i);
                }


                string soubor = Path.Combine(output, dl5.NazevSouboru());
                File.WriteAllTextAsync(soubor, dl5.ToString());
                Console.WriteLine(string.Format("Vytvořen soubor: {0}", soubor));
            }
        }

    }

    class DL5 {
        public string IcDodavatele, OznaceniDl, IcOdberatele, IdSkladu;
        public Nullable<int> CisloObjednavky, KodovaStranka, PocetPolozek;
        public Nullable<float> SoucetBezDph, SoucetSDph, SoucetBezDphSazba1, SoucetSDphSazba1, SoucetBezDphSazba2, SoucetSDphSazba2;
        public List<DL5_item> Polozky = new List<DL5_item>();

        public DL5() {}

        public override string ToString() {
            string output = String.Format(new NullFormat(),
                "{0,-20}{1,-20}{2,-20}{3,12:N0}{4,5:N0}{5,8:N0}{6,12:N2}{7,12:N2}{8,12:N2}{9,12:N2}{10,12:N2}{11,12:N2}{12,-10}",
                IcDodavatele, OznaceniDl, IcOdberatele, CisloObjednavky, KodovaStranka, PocetPolozek, SoucetBezDph,
                SoucetSDph, SoucetBezDphSazba1, SoucetSDphSazba1, SoucetBezDphSazba2, SoucetSDphSazba2, IdSkladu
            ) + Environment.NewLine;

            foreach(DL5_item polozka in Polozky) {
                output += polozka.ToString() + Environment.NewLine;
            }

            return output;
        }

        public string NazevSouboru() {
            return OznaceniDl + ".DL5";
        }

    }

    class DL5_item {
        public string Kod, Nazev, Sarze, Expirace, CarovyKod, KodDodavatele, Certifikat;
        public Nullable<float> Dph, VyrobCena, NakupCenaSDph, ProdejCenaSDph, Mnozstvi, NakupniCenaBezDph;
        public Nullable<int> Skupina, DruhKodu;

        public DL5_item() {}

        public override string ToString() {
            return String.Format(new NullFormat(),
                "{0,7}{1,-60}{2,1:N0}{3,7:N2}{4,11:N2}{5,11:N2}{6,11:N2}{7,10:N2}{8,-20}{9,-10}{10,-20}{11,-20}{12,1:N0}{13,11:N2}{14,-20}",
                Kod, Nazev, Skupina, Dph, VyrobCena, NakupCenaSDph, ProdejCenaSDph, Mnozstvi, Sarze, Expirace, CarovyKod,
                KodDodavatele, DruhKodu, NakupniCenaBezDph, Certifikat
            );
        }
    }

    public class NullFormat : IFormatProvider, ICustomFormatter {
    public object GetFormat(Type service) {
        if (service == typeof(ICustomFormatter)) {
            return this;
        }
        else {
            return null;
        }
    }

    public string Format(string format, object arg, IFormatProvider provider) {
        if (arg == null) {
            return "";
        }
        IFormattable formattable = arg as IFormattable;
        if (formattable != null) {
            return formattable.ToString(format, provider);
        }
        return arg.ToString();
    }
}
}