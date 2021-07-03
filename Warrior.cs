using System;
using Enemies;

namespace Defenders
{
    class Warrior : IDefender
    {
        protected readonly string name;
        protected readonly int strength;
        protected static readonly Random rng = new Random(1597);

        public Warrior(string name, int strength)
        {
            this.name = name;
            this.strength = strength;
        }

        public virtual int AtakGiant(Giant enemy)
        {
            Console.WriteLine($"Warrior {name} is attacking");
            Console.WriteLine($"Warrior {name} attacked Giant for {strength}");
            return strength;
        }

        public virtual int AtakOgre(Ogre enemy)
        {
            Console.WriteLine($"Warrior {name} is attacking");
            if (strength - enemy.Armor > 0)
            {
                Console.WriteLine($"Warrior {name} attacked Ogre for {strength}");
                return strength - enemy.Armor;
            }
            Console.WriteLine($"Warrior {name} attacked Ogre for 1");
            return 1;
        }

        public virtual int AtakRat(Rat enemy)
        {
            Console.WriteLine($"Warrior {name} is attacking");
            if (rng.NextDouble() < enemy.Speed / 100)
            {
                Console.WriteLine($"Warrior {name} missed Rat");
                return 0;
            }
            Console.WriteLine($"Warrior {name} attacked Rat for {strength}");
            enemy.IncreaseSpeed();
            return strength;
        }

    }
}