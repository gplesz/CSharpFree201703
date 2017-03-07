using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03ValtozokHasznalata
{
    class Program
    {
        static void Main(string[] args)
        {

            //korábban ezt így írtuk volna:
            //string valasz = "";

            var valasz = "";
            Console.WriteLine("Milyen ebédre vásároljunk be?");
            Console.WriteLine("Vega=húsmentes");
            Console.WriteLine("különben húsos");
            Console.WriteLine("Kérem a választ, majd egy entert:");

            //be kell kérnünk a felhasználó válaszát
            valasz = Console.ReadLine();

            //bool VegatIrtAFelhasznalo;

            var VegatIrtAFelhasznalo = valasz.ToLower() == "Vega".ToLower();

            //A típusok nem keveredhetnek
            //VegatIrtAFelhasznalo = valasz; //Ez nem lefordítható, a fodító hibát ad

            if (VegatIrtAFelhasznalo)
            {
                //ha péntek van, akkor
                Console.WriteLine("Karfiol");
                Console.WriteLine("Tejszín");
                Console.WriteLine("Hagyma");
            }
            else
            {
                //ha nem péntek van, akkor
                Console.WriteLine("Marhalábszár");
                Console.WriteLine("Hagyma");
                Console.WriteLine("Pirospaprika");
                Console.WriteLine("Olaj");
            }

            Console.ReadLine();
        }
    }
}
