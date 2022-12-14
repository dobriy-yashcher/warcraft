// Turushkin Sergey, 320P, "Warcraft"

namespace Unit
{
    public abstract class Unit
    {
        public double health;
        public double cost;
        public string name;
        public int lvl;
        public bool isDestroyed;
        public double maxHealth;

        public Unit(double health, double cost, string name, int lvl = 1)
        {
            this.health = health;
            this.maxHealth = health;
            this.cost = cost;
            this.name = name;
            this.lvl = lvl;
            isDestroyed = false;
        }

        public abstract void Attack(Unit unt);
    }
}
