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
                if (item.GetType().Equals(typeof(Kor)))
                {
                    Kor kor = (Kor)item;
                    Console.WriteLine($"{kor.AlakzatTipus}\tkerület: {item.Kerulet():N2} \tterület: {item.Terulet():N2} \tsugara: {kor.Sugar:N2}");
                }
                else if (item.GetType().Equals(typeof(Negyzet)))
                {
                    Negyzet negyzet = (Negyzet)item;
                    Console.WriteLine($"{negyzet.AlakzatTipus}\tkerület: {item.Kerulet():N2} \tterület: {item.Terulet():N2} \toldalának hossza: {negyzet.Oldal:N2}");
                }
            }

            Console.WriteLine("\nProgram vége!");
            Console.ReadKey();
        }
    }
}
