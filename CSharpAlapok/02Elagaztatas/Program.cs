using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Elagaztatas
{
    class Program
    {
        static void Main(string[] args)
        {

            //if (false)  //Ezt tesztelésnek bennhagyom
            //Összehasonlítunk két értéket
            //az egyenlőségjel két oldalán lévő érték
            //ha egyenlő akkor true, ha nem akkor false
            if (DateTime.Now.DayOfWeek == DayOfWeek.Tuesday)
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
