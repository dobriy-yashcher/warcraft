using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit
{
    public abstract class Moveble : Unit
    {
        public double speed;

        public Moveble(double health, double cost, string name, double speed) : base(health, cost, name)
        {
            this.speed = speed;
        }

        public abstract void Move();
    }
}
