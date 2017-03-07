using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Bevezetes
{

    //   Program(C#) -> IL (Intermediate Language=Köztes nyelv)
    //
    //                       \ IL /
    //                       ------
    //                       |.NET|        |.NET|         |.NET|     
    //                       ------        ------         ------
    //                       WINDOWS       LINUX          Mac OS      Android   iOS
    //

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sziasztok itt vagyok");
            Console.WriteLine("Sziasztok itt vagyok");
            Console.WriteLine("Sziasztok itt vagyok");
            Console.ReadLine();
        }
    }
}
