using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit
{
    public class GuardTower : Unit
    {
        public double range;
        public double damage;
        public double attackSpeed;

        public GuardTower(double health, double cost, string name, double range, double damage, double attackSpeed) : base(health, cost, name)
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
