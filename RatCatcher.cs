using System;
using Enemies;

namespace Defenders
{
    class RatCatcher : IDefender
    {
        protected readonly string name;
        private bool hasRat;

        public RatCatcher(string name)
        {
            this.name = name;
            hasRat = false;
        }

        public int AtakGiant(Giant enemy)
        {
            if (hasRat)
            {
                Console.WriteLine($"Rat catcher {name} ignores Giant");

                return 0;
            }
            Console.WriteLine($"Rat catcher {name} is attacking");
            Console.WriteLine($"Rat catcher {name} attacked Giant for 0");
            return 0;
        }

        public int AtakOgre(Ogre enemy)
        {
            Console.WriteLine($"Rat catcher {name} is attacking");
            if (hasRat)
            {
                Console.WriteLine($"Rat catcher {name} scared Ogre");
                hasRat = false;
                return enemy.HP;
            }
            else
            {
                Console.WriteLine($"Rat catcher {name} attacked Ogre for 0");
                return 0;
            }
        }

        public int AtakRat(Rat enemy)
        {
            Console.WriteLine($"Rat catcher {name} is attacking");
            if (hasRat)
            {
                Console.WriteLine($"Rat catcher {name} already has a rat");
                return 0;
            }
            Console.WriteLine($"Rat catcher {name} catches a rat");
            hasRat = true;
            return enemy.HP;
        }
    }
}