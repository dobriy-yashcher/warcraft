using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit
{
    public abstract class Unit
    {
        public double health;
        public double cost;
        public string name;
        public int lvl;
        public bool isDestroyed;
        //public int maxHealth;

        public Unit(double health, double cost, string name, int lvl = 1)
        {
            this.health = health;
            this.cost = cost;
            this.name = name;
            this.lvl = lvl;
            isDestroyed = false;
        }
    }
}
