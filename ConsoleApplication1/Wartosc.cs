using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja
{
    public struct Wartosc
    {
        private double cena;
        private double wartoscSentymentalna;

        public Wartosc(double cena, double wartoscSentymentalna)
        {
            if (cena < 0 || wartoscSentymentalna < 0)
            {
                throw new ValidationException("Wartość lub cena nie mogą być mniejsze niż 0 zl");
            }
            this.cena = cena;
            this.wartoscSentymentalna = wartoscSentymentalna;
        }

        public double Cena
        {
            get
            {
                return cena;
            }

            set
            {
                if (value < 0)
                {
                    throw new ValidationException("Cena nie może być mniejsza niż 0 zl");
                }
                cena = value;
            }
        }

        public double WartoscSentymentalna
        {
            get
            {
                return wartoscSentymentalna;
            }

            set
            {
                if (value < 0)
                {
                    throw new ValidationException("Wartość sentymentalna nie może być mniejsza niż 0");
                }
                wartoscSentymentalna = value;
            }
        }
    }
}
