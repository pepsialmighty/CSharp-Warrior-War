using System;
using warriorwar.Enum;

namespace warriorwar
{
    class Program
    {
        static Random rng = new Random();

        static void Main(string[] args)
        {
            warrior goodGuy = new warrior("Justice", Faction.goodGuy);
            warrior badGuy = new warrior("Evil", Faction.badGuy);

            while (goodGuy.IsAlive && badGuy.IsAlive)
            {
                if (rng.Next(0,10) <5 )
                {
                    goodGuy.Attack(badGuy);
                }
                else
                {
                    badGuy.Attack(goodGuy);
                }

            }


            Console.ReadKey();
        }
    }
}
