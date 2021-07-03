using System;
using Enemies;

namespace Defenders
{
    class Archer : Warrior
    {
        private int arrows;

        public Archer(string name, int strength, int arrows) : base(name, strength)
        {
            this.arrows = arrows;
        }

        public override int AtakGiant(Giant enemy)
        {
            if (arrows == 0)
            {
                Console.WriteLine($"Archer {name} does not have arrows");
                return 0;
            }
            if (arrows == 1)
            {
                Console.WriteLine($"Archer {name} is attacking");
                Console.WriteLine($"Archer {name} attacked Giant for {strength}");
                arrows--;
                return strength;
            }
            Console.WriteLine($"Archer {name} is attacking");
            Console.WriteLine($"Archer {name} attacked Giant for twice * {strength}");
            arrows = arrows - 2;
            return 2 * strength;
        }

        public override int AtakOgre(Ogre enemy)
        {
            if (arrows == 0)
            {
                Console.WriteLine($"Archer {name} does not have arrows");
                return 0;
            }
            Console.WriteLine($"Archer {name} is attacking");
            if (strength - enemy.Armor > 0)
            {
                Console.WriteLine($"Archer {name} attacked Ogre for {strength - enemy.Armor}");
                arrows--;
                return strength - enemy.Armor;
            }
            Console.WriteLine($"Archer {name} attacked Ogre for 1");
            arrows--;
            return 1;
        }

        public override int AtakRat(Rat enemy)
        {
            if (arrows == 0)
            {
                Console.WriteLine($"Archer {name} does not have arrows");
                return 0;
            }
            Console.WriteLine($"Archer {name} is attacking");
            arrows--;
            if (rng.NextDouble() < enemy.Speed / 100)
            {
                Console.WriteLine($"Archer {name} missed Rat");
                return 0;
            }
            Console.WriteLine($"Archer {name} attacked Rat for {strength}");
            enemy.IncreaseSpeed();
            return strength;
        }
    }
}