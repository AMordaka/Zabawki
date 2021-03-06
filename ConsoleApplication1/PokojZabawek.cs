﻿using System;
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

        internal void usunZabawke(Zabawka zabawka)
        {
            listaZabawek.Remove(zabawka);
        }

        internal void wyswietlPokoj()
        {
            foreach(Zabawka zabawka in listaZabawek)
            {
                if (zabawka is InterfaceSzybkosc)
                {
                    InterfaceSzybkosc temp = (InterfaceSzybkosc)(zabawka);
                    Console.WriteLine(zabawka.Nazwa + " " + temp.Szybkosc);
                }

                if (zabawka is InterfaceGlebokosc)
                {
                    InterfaceGlebokosc temp = (InterfaceGlebokosc)(zabawka);
                    Console.WriteLine(zabawka.Nazwa + " " + temp.Glebokosc);
                }

                if (zabawka is InterfaceWysokosc)
                {
                    InterfaceWysokosc temp = (InterfaceWysokosc)(zabawka);
                    Console.WriteLine(zabawka.Nazwa + " " + temp.Wysokosc);
                }

            }
        }

        internal void zmienSzybkoscWszystkich(double szybkosc)
        {
            foreach (Zabawka zabawka in listaZabawek)
            {
                if(zabawka is InterfaceSzybkosc)
                {
                    InterfaceSzybkosc temp = (InterfaceSzybkosc)(zabawka);
                    temp.Szybkosc = szybkosc;
                }
                
            }
        }

        internal void zmienWysokoscWszystkich(double wysokosc)
        {
            foreach (Zabawka zabawka in listaZabawek)
            {
                if (zabawka is InterfaceWysokosc)
                {
                    InterfaceWysokosc temp = (InterfaceWysokosc)(zabawka);
                    temp.Wysokosc = wysokosc;
                }
            }
        }

        internal void zmienGlebokoscWszystkich(double glebokosc)
        {
            foreach (Zabawka zabawka in listaZabawek)
            {
                if (zabawka is InterfaceGlebokosc)
                {
                    InterfaceGlebokosc temp = (InterfaceGlebokosc)(zabawka);
                    temp.Glebokosc = glebokosc;
                }
            }
        }

        private static void Print(string s)
        {
            Console.WriteLine(s);
        }


    
    }
}
