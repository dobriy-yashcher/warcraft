using Unit;

namespace Warcraft
{
    internal static class Program
    {
        static void Main()
        {
            var peasant = new Peasant(100, 1.5, "peasant", 2.4);
            var footman = new Footman(150, 2.2, "footman", 2.2, 30, 1.1, 50);
            var mage = new Mage(50, 15, "mage", 2, 50, 2, 10, 7, 80);
            var guardTower = new GuardTower(450, 50, "guardTower", 5, 50, 1);
            var dragon = new Dragon(1000, 150, "dragon", 5.5, 100, 3, 0, 8, 500);


        }
    }
}