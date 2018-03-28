using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja
{

    class Zabawka
    {

        Wartosc wartoscBazowa;
        double wiek;
        String nazwa;
        double szybkosc;
        double wysokosc;
        double glebokosc;

        public Zabawka(String nazwa, double szybkosc, double wysokosc, double glebokosc)
        {
            this.nazwa = nazwa;
            this.szybkosc = szybkosc;
            this.wysokosc = wysokosc;
            this.glebokosc = glebokosc;
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

        public double Szybkosc
        {
            get
            {
                return szybkosc;
            }

            set
            {
                if(value > szybkosc)
                {
                    onZwiekszonoWartosc?.Invoke();
                }
                szybkosc = value;
            }
        }

        public double Wysokosc
        {
            get
            {
                return wysokosc;
            }

            set
            {
                if (value > wysokosc)
                {
                    onZwiekszonoWartosc?.Invoke();
                }
                wysokosc = value;
            }
        }

        public double Glebokosc
        {
            get
            {
                return glebokosc;
            }

            set
            {
                if (value > glebokosc)
                {
                    onZwiekszonoWartosc?.Invoke();
                }
                glebokosc = value;
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
