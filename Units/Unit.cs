using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Units
{
    public abstract class Unit
    {
        public decimal health;
        public decimal cost;
        public string name;
        public int lvl;
        public bool isDestroyed;
        //public int maxHealth;

        public Unit(decimal health, decimal cost, string name, int lvl = 1)
        {
            this.health = health;
            this.cost = cost;
            this.name = name;
            this.lvl = lvl;
            isDestroyed = false;
        }
    }
}
