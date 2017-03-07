using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Ciklus
{
    class Program
    {
        static void Main(string[] args)
        {
            //Blokkos kijelölés/vissza:
            //Ctrl+K, Ctrl+C/Ctrl+K, Ctrl+U

            //Ezt automatizáljuk
            //Console.WriteLine("1");
            //Console.WriteLine("2");
            //Console.WriteLine("3");
            //Console.WriteLine("4");
            //Console.WriteLine("5");
            //Console.WriteLine("6");
            //Console.WriteLine("7");
            //Console.WriteLine("8");
            //Console.WriteLine("9");
            //Console.WriteLine("10");

                 //kezdőérték; feltétel; lépésszámoló
            for (int i = 1; i < 100; i++) //az i++ az a következő rövidítése: i = i + 1
            {
                Console.WriteLine(i);
                System.Threading.Thread.Sleep(1000);
            }

            Console.ReadLine();
        }
    }
}
