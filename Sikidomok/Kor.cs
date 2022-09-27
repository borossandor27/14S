using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomok
{
    internal class Kor : Sikidom
    {
        double sugar;

        public double Sugar { get => sugar; set => sugar = value; }

        public Kor(double sugar) :base("Kör")
        {
            this.sugar = sugar;
        }

        public override double Kerulet()
        {
            return 2*sugar*Math.PI;
        }

        public override double Terulet()
        {
            return sugar*sugar*Math.PI;
        }
    }
}
