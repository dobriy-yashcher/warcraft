using Unit;

namespace Warcraft
{
    internal static class Program
    {
        static void Main()
        {
            {
                var dragon = new Dragon(10, 2.2, "dragon", 2.4, 50, 7, 8, 7, 80);
                Console.WriteLine("hi.");
                dragon.FireBreath();
            }
        }
    }
}