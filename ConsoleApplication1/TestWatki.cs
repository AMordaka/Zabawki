using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja
{
    class TestWatki
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

        PokojZabawek pokoj = new PokojZabawek();

        public void test1()
        {
            while (true)
            {
                pokoj.onDodanoZabawke += onDodanoZabawkeKomunikat;
                pokoj.onOsiagnietoLimit += onOsiagnietoLimitKomunikat;
                Zabawka samochod = new ZabawkaSamochod("Samochod", 10, 10);
                samochod.onZwiekszonoWartosc += onZwiekszonoWartoscKomunikat;
                Zabawka samolot = new ZabawkaSamolot("Samolot", 20, 20);
                pokoj.dodajZabawke(samochod);
                pokoj.dodajZabawke(samolot);
                pokoj.wyswietlPokoj();
                pokoj.zmienSzybkoscWszystkich(5.2);
                pokoj.wyswietlPokoj();
                Zabawka samochod2 = new ZabawkaSamochod("Samochoddrugi", 10, 10);
                pokoj.dodajZabawke(samochod2);
                Console.WriteLine("Usuwanie");
                Console.WriteLine("---------");
                pokoj.usunZabawke(samochod2);
                pokoj.wyswietlPokoj();
                Console.ReadLine();
            }
        }

    }
}
