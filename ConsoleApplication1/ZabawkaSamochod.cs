using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja
{
    public class ZabawkaSamochod : Zabawka, InterfaceSzybkosc, InterfaceGlebokosc
    {

        private double glebokosc;
        private double szybkosc;

        public ZabawkaSamochod(String nazwa, double glebokosc, double szybkosc) : base(nazwa)
        {
            this.glebokosc = glebokosc;
            this.szybkosc = szybkosc;
        }

        public double Szybkosc { get => szybkosc; set => szybkosc = value; }
        public double Glebokosc { get => glebokosc; set => glebokosc = value; }

    }
}
