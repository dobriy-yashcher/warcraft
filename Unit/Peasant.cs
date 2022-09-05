// Turushkin Sergey, 320P, "Warcraft"

namespace Unit
{
    public class Peasant : Moveble
    {
        public Peasant(double health, double cost, string name, double speed) : base(health, cost, name, speed)
        { }

        public void Mining()
        { }

        public void Choping()
        { }

        public override void Move()
        { }

        public override void Attack(Unit unt)
        { }
    }
}
