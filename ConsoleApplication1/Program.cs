using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja
{
    class Program
    {

        public static void onDodanoZabawkeKomunikat()
        {
            Console.WriteLine("Dodano Zabawke!");
        }

        public static void onZwiekszonoWartoscKomunikat()
        {
            Console.WriteLine("Zwiekszono wartosc!");
        }

        public static void onOsiagnietoLimitKomunikat()
        {
            Console.WriteLine("OsiagnietoLimit !");
        }



        static void Main(string[] args)
        {
            PokojZabawek pokoj = new PokojZabawek();
            pokoj.onDodanoZabawke += onDodanoZabawkeKomunikat;
            pokoj.onOsiagnietoLimit += onOsiagnietoLimitKomunikat;
            Zabawka samochod = new Zabawka("Samochod", 10, 10, 10);
            samochod.onZwiekszonoWartosc += onZwiekszonoWartoscKomunikat;
            samochod.Szybkosc = 20;
            samochod.Szybkosc = 10;
            Zabawka samolot = new Zabawka("Samolot", 20, 20, 20);
            pokoj.dodajZabawke(samochod);
            pokoj.dodajZabawke(samolot);
            pokoj.wyswietlPokoj();
            pokoj.zmienSzybkoscWszystkich(5.2);
            pokoj.wyswietlPokoj();

            Zabawka nowa = new Zabawka("Nowa", 1, 1, 1);
            pokoj.dodajZabawke(nowa);
            Console.ReadLine();
        }
    }

}
