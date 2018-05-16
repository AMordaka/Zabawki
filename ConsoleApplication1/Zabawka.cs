using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja
{

    public class  Zabawka
    {

        Wartosc wartoscBazowa;
        double wiek;
        String nazwa;

        public Zabawka(String nazwa)
        {
            this.nazwa = nazwa;
        }

        public delegate void ZwiekszonoWartosc();
        public event ZwiekszonoWartosc onZwiekszonoWartosc;

        public double WartoscAktualna
        {
            get
            {
                return WartoscBazowa.WartoscSentymentalna * WartoscBazowa.Cena / this.wiek;
            }
        }

        
        public string Nazwa
        {
            get
            {
                return nazwa;
            }

            set
            {
                nazwa = value;
            }
        }

        public Wartosc WartoscBazowa
        {
            get
            {
                return wartoscBazowa;
            }

            set
            {
                wartoscBazowa = value;
            }
        }

        public double Wiek
        {
            get
            {
                return wiek;
            }

            set
            {
                wiek = value;
            }
        }
    }
}
