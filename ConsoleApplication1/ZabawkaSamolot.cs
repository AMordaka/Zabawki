using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja
{
    public class ZabawkaSamolot : Zabawka, InterfaceWysokosc, InterfaceSzybkosc
    {
        private double wysokosc;
        private double szybkosc;

        public ZabawkaSamolot(String nazwa, double wysokosc, double szybkosc) : base(nazwa)
        {
            this.wysokosc = wysokosc;
            this.szybkosc = szybkosc;
        }

        public double Wysokosc { get => wysokosc; set => wysokosc = value; }
        public double Szybkosc { get => szybkosc; set => szybkosc = value; }


    }
}
