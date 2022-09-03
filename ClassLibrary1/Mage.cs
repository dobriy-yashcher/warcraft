using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit
{
    public class Mage : Range
    {
        public Mage(double health, double cost, string name, double speed,
                    double damage, double attackSpeed, double armor, double range, double mana)
                    : base(health, cost, name, speed, damage, attackSpeed, armor, range, mana) { }

        public void FireBall() { }

        public void Blizzard() { }

        public void Heal() { }

        public override void Attack() { }

        public override void Move() { }
    }
}
