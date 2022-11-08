using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTagdij
{
    internal class Tag
    {
        int azon;
        string nev;
        int szulev;
        string irszam;
        string orsz;

        public int Azon { get => azon; set => azon = value; }
        public string Nev { get => nev; set => nev = value; }
        public int Szulev { get => szulev; set => szulev = value; }
        public string Irszam { get => irszam; set => irszam = value; }
        public string Orsz { get => orsz; set => orsz = value; }

        public Tag(int azon, string nev, int szulev, string irszam, string orsz)
        {
            Azon = azon;
            Nev = nev;
            Szulev = szulev;
            Irszam = irszam;
            Orsz = orsz;
        }

        public int Kor()
        {
            return DateTime.Now.Year-szulev;
        }
        public override string ToString()
        {
            return $"{nev} ({Kor()})";
        }
    }
}
