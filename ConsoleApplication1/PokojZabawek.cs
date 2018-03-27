using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja
{
    class PokojZabawek
    {
        private List<Zabawka> listaZabawek = new List<Zabawka>();

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

        void dodajZabawke(Zabawka zabawka)
        {
            listaZabawek.Add(zabawka);
        }

        void wyswietlPokoj()
        {
            foreach(Zabawka zabawka in listaZabawek)
            {
                Console.WriteLine(zabawka.Nazwa + " " + zabawka.Szybkosc + " " + zabawka.Wysokosc + " " + zabawka.Glebokosc);
            }
        }

        void zmienSzybkoscWszystkich(double szybkosc)
        {
            foreach (Zabawka zabawka in listaZabawek)
            {
                zabawka.Szybkosc += szybkosc;
            }
        }

        void zmienWysokoscWszystkich(double wysokosc)
        {
            foreach (Zabawka zabawka in listaZabawek)
            {
                zabawka.Wysokosc += wysokosc;
            }
        }

        void zmienGlebokoscWszystkich(double glebokosc)
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

        static void Main(string[] args)
        {
            PokojZabawek pokoj = new PokojZabawek();
            Zabawka samochod = new Zabawka("Samochod", 10, 10, 10);
            Zabawka samolot = new Zabawka("Samolot", 20, 20, 20);
            pokoj.dodajZabawke(samochod);
            pokoj.dodajZabawke(samolot);
            pokoj.wyswietlPokoj();
            pokoj.zmienSzybkoscWszystkich(5.2);
            pokoj.wyswietlPokoj();
            Console.ReadLine();
        }
    }
}
