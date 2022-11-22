using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_Gyumolcsos
{
    internal class Gyumolcs
    {
        int id;
        string nev;
        double egysegar;
        double mennyiseg;

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public double Egysegar { get => egysegar; set => egysegar = value; }
        public double Mennyiseg { get => mennyiseg; set => mennyiseg = value; }

        public Gyumolcs(int id, string nev, double egysegar, double mennyiseg)
        {
            Id = id;
            Nev = nev;
            Egysegar = egysegar;
            Mennyiseg = mennyiseg;
        }
        public override string ToString()
        {
            return $"{nev} ({egysegar.ToString("0.00")})";
        }
    }
}
