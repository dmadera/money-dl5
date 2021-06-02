using System;
using System.Collections.Generic;

namespace moneys4_dl5
{
    class DL5 {
        public string IcDodavatele, OznaceniDl, IcOdberatele, IdSkladu;
        public Nullable<int> CisloObjednavky, KodovaStranka, PocetPolozek;
        public Nullable<float> SoucetBezDph, SoucetSDph, SoucetBezDphSazba1, SoucetSDphSazba1, SoucetBezDphSazba2, SoucetSDphSazba2;
        public List<DL5Item> Polozky = new List<DL5Item>();

        public DL5() {}

        public override string ToString() {
            string output = String.Format(new NullFormat(),
                "{0,-20}{1,-20}{2,-20}{3,12:#}{4,5:#}{5,8:#}{6,10:0.00}{7,10:0.00}{8,10:0.00}{9,10:0.00}{10,10:0.00}{11,10:0.00}{12,-10}",
                IcDodavatele, OznaceniDl, IcOdberatele, CisloObjednavky, KodovaStranka, PocetPolozek, SoucetBezDph,
                SoucetSDph, SoucetBezDphSazba1, SoucetSDphSazba1, SoucetBezDphSazba2, SoucetSDphSazba2, IdSkladu
            ) + Environment.NewLine;

            foreach(DL5Item polozka in Polozky) {
                output += polozka.ToString() + Environment.NewLine;
            }
            return output;
        }

        public string NazevSouboru() {
            return OznaceniDl + ".DL5";
        }
    }

    class DL5Item {
        public string Kod, Nazev, Sarze, Expirace, CarovyKod, KodDodavatele, Certifikat;
        public Nullable<float> Dph, VyrobCena, NakupCenaSDph, ProdejCenaSDph, Mnozstvi, NakupniCenaBezDph;
        public Nullable<int> Skupina, DruhKodu;

        public DL5Item() {}

        public override string ToString() {
            return String.Format(new NullFormat(),
                "{0,7}{1,-60}{2,1:#}{3,5:0.00}{4,9:0.00}{5,9:0.00}{6,9:0.00}{7,8:0.00}{8,-20}{9,-10}{10,-20}{11,-20}{12,1:0}{13,9:0.00}{14,-20}",
                Kod, Nazev, Skupina, Dph, VyrobCena, NakupCenaSDph, ProdejCenaSDph, Mnozstvi, Sarze, Expirace, CarovyKod,
                KodDodavatele, DruhKodu, NakupniCenaBezDph, Certifikat
            );
        }
    }

    public class NullFormat : IFormatProvider, ICustomFormatter {
        public object GetFormat(Type service) {
            if (service == typeof(ICustomFormatter)) return this;
            
            return null;
        }

        public string Format(string format, object arg, IFormatProvider provider) {
            if (arg == null) return "";
                
            IFormattable formattable = arg as IFormattable;
            if (formattable != null) return formattable.ToString(format, provider);

            return arg.ToString();
        }
    }
}