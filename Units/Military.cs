using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Units
{
    public abstract class Military : Moveble
    {
        public decimal damage;
        public decimal attackSpeed;
        public decimal armor;

        public Military(decimal health, decimal cost, string name, decimal speed, 
                        decimal damage, decimal attackSpeed, decimal armor) : base(health, cost, name, speed)
        {
            this.damage = damage;
            this.attackSpeed = attackSpeed;
            this.armor = armor;
        }

        public abstract void Attack();
    }
}
