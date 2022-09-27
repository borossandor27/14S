using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Sikidom> sikidoms = new List<Sikidom>();

            sikidoms.Add(new Kor(2.5));
            sikidoms.Add(new Kor(5.1));
            sikidoms.Add(new Negyzet(2.5));
            sikidoms.Add(new Negyzet(4.1));

            foreach (Sikidom item in sikidoms)
            {
                string tipus = "";
                if (item.GetType().Equals(typeof(Kor)))
                {
                    tipus = "Kör";
                }
                else if (item.GetType().Equals(typeof(Negyzet)))
                {
                    tipus = "Négyzet";
                }
                Console.WriteLine($"{tipus}\tkerület: {item.Kerulet():N2} \tterület: {item.Terulet():N2}");
            }

            Console.WriteLine("\nProgram vége!");
            Console.ReadKey();
        }
    }
}
