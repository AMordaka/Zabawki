using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja
{
    public class PokojZabawek
    {
        public delegate void OsiagnietoLimit();
        public delegate void DodanoZabawke();
        public event DodanoZabawke onDodanoZabawke;
        public event OsiagnietoLimit onOsiagnietoLimit;
        private List<Zabawka> listaZabawek = new List<Zabawka>();
        private static int limitZabawek = 2;


        internal List<Zabawka> ListaZabawek
        {
            get
            {
                return listaZabawek;
            }

            set
            {
                listaZabawek = value;
            }
        }

        internal int LimitZabawek { get => limitZabawek; set => limitZabawek = value; }

        internal void dodajZabawke(Zabawka zabawka)
        {
            int liczbaZabawek = listaZabawek.Count;
            if(limitZabawek > liczbaZabawek)
            {
                listaZabawek.Add(zabawka);
                onDodanoZabawke?.Invoke();
            }
            else
            {
                onOsiagnietoLimit?.Invoke();
            }


        }

        internal void wyswietlPokoj()
        {
            foreach(Zabawka zabawka in listaZabawek)
            {
                Console.WriteLine(zabawka.Nazwa + " " + zabawka.Szybkosc + " " + zabawka.Wysokosc + " " + zabawka.Glebokosc);
            }
        }

        internal void zmienSzybkoscWszystkich(double szybkosc)
        {
            foreach (Zabawka zabawka in listaZabawek)
            {
                zabawka.Szybkosc += szybkosc;
            }
        }

        internal void zmienWysokoscWszystkich(double wysokosc)
        {
            foreach (Zabawka zabawka in listaZabawek)
            {
                zabawka.Wysokosc += wysokosc;
            }
        }

        internal void zmienGlebokoscWszystkich(double glebokosc)
        {
            foreach (Zabawka zabawka in listaZabawek)
            {
                zabawka.Glebokosc += glebokosc;
            }
        }

        private static void Print(string s)
        {
            Console.WriteLine(s);
        }


    
    }
}
