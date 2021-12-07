using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Definirajte klasu Stablo sa sljedećim članicama:
a. varijabla tipa bool otpadajuListovi
b. varijabla tipa string vrstaStabla
c. svojstvo OtpadajuListovi (get() i set())
d. konstruktor Stablo(bool) koji će dodijeliti vrijednost proslijeđenog argumenta
varijabli otpadajuListovi
e. override metode ToString()
Definirajte objekt stablo1 tipa Stablo pomoću konstruktora te proslijedite vrijednost
false. Definirajte objekt stablo2 tipa Stablo pomoću konstruktora te proslijedite
vrijednost true.
Ispišite podatke o objektima koristeći ToString() metodu, na način da ukoliko je
vrijednost varijable otpadajuListovi true, vrijednost varijable vrstaStabla je
bijelogorično, a ukoliko je vrijednost varijable otpadajuListovi false, vrijednost
varijable vrstaStabla je crnogorično.*/

namespace Ispit2
{
    internal class Program
    {
        class Stablo
        {
            public bool otpadajuListovi;
            string vrstaStabla;

            public void SetotpadajuListovi(bool value)
            {
                otpadajuListovi = value;
            }

            public bool GetotpadajuListovi()
            {
                return otpadajuListovi;
            }

            

        }

        static void Main(string[] args)
        {
            bool otpadajuListovi;
            
            Stablo stablo1 = new Stablo();
           

            Stablo stablo2 = new Stablo();


            Console.WriteLine("Unesi 'true' ili 'false' ako stablu otpada lišće.");
            otpadajuListovi = Convert.ToBoolean( Console.ReadLine());

            if (otpadajuListovi == true)
            {
                Console.WriteLine("Stablo je bjelogorično.");
            }

            if (otpadajuListovi == false)
            {
                Console.WriteLine("Stablo je crnogorično.");
            }

            Console.ReadKey();
        }
    }
}
