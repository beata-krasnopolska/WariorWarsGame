using System;
using System.Threading;
using WariorWars.Enum;

namespace WariorWars
{
    class Program
    {
        static Random rng = new Random();

        static void Main(string[] args)
        {
            Warior goodGuy = new Warior("Zwirek", Faction.goodGuy);
            Warior badGuy = new Warior("Muchomorek", Faction.badGuy);

            while (goodGuy.IsAlive && badGuy.IsAlive)
            {
                if (rng.Next(0, 10) > 5)
                {
                    goodGuy.Attack(badGuy);
                }
                else
                {
                    badGuy.Attack(goodGuy);
                }
                Thread.Sleep(50);
            }
        }
    }
}
