using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Units
{
    public class Peasant : Moveble
    {
        public Peasant(decimal health, decimal cost, string name, decimal speed) : base(health, cost, name, speed)
        { }

        public void Mining()
        { }

        public void Choping()
        { }

        public override void Move()
        { }
    }
}
