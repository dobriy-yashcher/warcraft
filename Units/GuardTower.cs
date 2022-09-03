using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Units
{
    public class GuardTower : Unit
    {
        public decimal range;
        public decimal damage;
        public decimal attackSpeed;

        public GuardTower(decimal health, decimal cost, string name, decimal range, decimal damage, decimal attackSpeed) : base(health, cost, name)
        {
            this.range = range;
            this.damage = damage;
            this.attackSpeed = attackSpeed;
        }

        public void Attack(Unit unt) 
        {
            unt.health -= damage;

            if (unt.health <= 0)
                unt.isDestroyed = true;
                unt.health = 0;
        }
    }
}
