using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomok
{
    abstract class Sikidom
    {
        readonly string alakzatTipus;

        public string AlakzatTipus { get => alakzatTipus;  }

        protected Sikidom(string alakzatTipus)
        {
            this.alakzatTipus = alakzatTipus;
        }

        abstract public double Kerulet();
        public abstract double Terulet();
    }
}
