using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit
{
    public class Footman : Military
    {
        public Footman(double health, double cost, string name, double speed,
                       double damage, double attackSpeed, double armor)
                       : base(health, cost, name, speed, damage, attackSpeed, armor) { }

        public override void Attack()
        {

        }

        public void Berserker()
        {

        }

        public override void Move()
        {

        }

        public void Stun()
        {

        }
    }
}
