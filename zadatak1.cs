using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*(6 bodova) Napišite program koji će zatražiti od korisnika da unese tri
dvoznamenkasta broja te će izračunati i ispisati najveći od tri broja (npr. 12,17,15 ->
17).*/

namespace Ispit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int prviBroj;
            int drugiBroj;
            int treciBroj;
            Console.WriteLine("Unesi 3 dvoznamenkasta broja: ");

            prviBroj = Convert.ToInt32(Console.ReadLine());
            drugiBroj = Convert.ToInt32(Console.ReadLine());
            treciBroj = Convert.ToInt32(Console.ReadLine());

            if (prviBroj > drugiBroj && prviBroj > treciBroj)
            {
                Console.WriteLine("Najveći broj je " + prviBroj);
            }

            if (drugiBroj > prviBroj && drugiBroj > treciBroj)
            {
                Console.WriteLine("Najveći broj je " + drugiBroj);
            }

            if (treciBroj > drugiBroj && treciBroj > prviBroj)
            {
                Console.WriteLine("Najveći broj je " +treciBroj);
            }
            Console.WriteLine("kraj");
            Console.ReadKey();
           
            
        }
    }
}
