﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit
{
    public abstract class Military : Moveble
    {
        public double damage;
        public double attackSpeed;
        public double armor;

        public Military(double health, double cost, string name, double speed, 
                        double damage, double attackSpeed, double armor) : base(health, cost, name, speed)
        {
            this.damage = damage;
            this.attackSpeed = attackSpeed;
            this.armor = armor;
        }

        public abstract void Attack();
    }
}
