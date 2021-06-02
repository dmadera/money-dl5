using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Serialization;


using DLV_DL5;

namespace moneys4_dl5 {
    class Xml2DL5 {
        private S5Data data;
        private string input;
        private string output;

        public Xml2DL5(string input, string output) {
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

        public void GenerateFiles() {
            if(data == null || data.DodaciListVydanyList == null) throw new Exception("Chybný XML soubor.");

            int resultI = 0; float resultF = 0;

            foreach(S5DataDodaciListVydany dl in data.DodaciListVydanyList) {
                DL5 dl5 = new DL5() {
                    IcDodavatele = dl.MojeFirma.IC,
                    OznaceniDl = dl.CisloDokladu,
                    IcOdberatele = dl.Adresa.Firma.ICO,
                    CisloObjednavky = int.TryParse(Regex.Replace(dl.Odkaz, @"[^0-9]+", ""), out resultI) ? resultI : null,
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

                const int snizena = 0, zakladni = 1;
                int druhSazby = -1;
                float soucetBezDphSazba1 = 0, SoucetSDphSazba1 = 0;
                float soucetBezDphSazba2 = 0, SoucetSDphSazba2 = 0;
                foreach(S5DataDodaciListVydanyDetailniRozpisDPHDetailniRozpisDPH rozpisDPH in dl.DetailniRozpisDPH.DetailniRozpisDPH) {
                    druhSazby = (int) rozpisDPH.SazbaDPH.DruhSazby.Value;
                    if(druhSazby == snizena) {
                        soucetBezDphSazba1 += float.TryParse(rozpisDPH.SumaZaklad, out resultF) ? resultF : 0;
                        SoucetSDphSazba1 += float.TryParse(rozpisDPH.SumaCelkem, out resultF) ? resultF : 0;
                    } else if(druhSazby == zakladni) {
                        soucetBezDphSazba2 += float.TryParse(rozpisDPH.SumaZaklad, out resultF) ? resultF : 0;
                        SoucetSDphSazba2 += float.TryParse(rozpisDPH.SumaCelkem, out resultF) ? resultF : 0;
                    }
                }

                dl5.SoucetBezDphSazba1 = soucetBezDphSazba1;
                dl5.SoucetSDphSazba1 = SoucetSDphSazba1;
                dl5.SoucetBezDphSazba2 = soucetBezDphSazba2;
                dl5.SoucetSDphSazba2 = SoucetSDphSazba2;

                foreach(S5DataDodaciListVydanyPolozkyPolozkaDodacihoListuVydaneho pol in dl.Polozky.PolozkaDodacihoListuVydaneho) {
                    DL5Item dl5i = new DL5Item() {
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

                System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
                string soubor = Path.Combine(output, dl5.NazevSouboru());
                File.WriteAllTextAsync(soubor, dl5.ToString(), Encoding.GetEncoding(1250));
                Console.WriteLine(string.Format("Vytvořen soubor: {0}", soubor));
            }
        }

    }
}