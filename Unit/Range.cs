using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit
{
    public abstract class Range : Military
    {
        public double range;
        public double mana;

        public Range(double health, double cost, string name, double speed,
                     double damage, double attackSpeed, double armor, double range, double mana)
                     : base(health, cost, name, speed, damage, attackSpeed, armor)
        {
            this.range = range;
            this.mana = mana;
        }
    }
}
