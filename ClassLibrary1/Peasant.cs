using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit
{
    public class Peasant : Moveble
    {
        public Peasant(double health, double cost, string name, double speed) : base(health, cost, name, speed)
        { }

        public void Mining()
        { }

        public void Choping()
        { }

        public override void Move()
        { }
    }
}
