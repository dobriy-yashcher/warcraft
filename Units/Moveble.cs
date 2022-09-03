using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Units
{
    public abstract class Moveble : Unit
    {
        public decimal speed;

        public Moveble(decimal health, decimal cost, string name, decimal speed) : base(health, cost, name)
        {
            this.speed = speed;
        }

        public abstract void Move();
    }
}
