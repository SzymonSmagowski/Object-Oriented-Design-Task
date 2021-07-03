using System;
using System.Collections.Generic;
using Defenders;
using Enemies;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            var enemies = new List<Enemy>()
            {
                new Rat("Snitches", 11, 10),
                new Rat("Sneaky", 1, 90),
                new Ogre("Mezrog", 60, 5),
                new Ogre("Zogut", 10, 5),
                new Rat("Cheesewiz", 15, 10),
                new Rat("Cheeseball", 7, 10),
                new Ogre("Guorob", 20, 1),
                new Rat("Julius Cheesar", 3, 10),
                new Giant("Kyo", 50),
                new Giant("Caw", 32),
                new Giant("World Destroyer", 1000),
                new Giant("Better World Destroyer", 10000),
            };


            var defenders = new List<IDefender>()
            {
                new Mage("Gandalf", 0, 100, 1000),
                new Warrior("Wakiza", 8),
                new Archer("Ajani", 10, 7),
                new Mage("Merlin", 15, 2, 10),
                new Archer("Alois", 10, 9),
                new Warrior("Werner", 3),
                new RatCatcher("Filip"),
                new FireMage("Rincewind", 10, 0, 1, 0.1),
            };

            foreach (var enemy in enemies)
                Attack(enemy, defenders);
        }

        static void Attack(Enemy enemy, IEnumerable<IDefender> defenders)
        {
            foreach (var defender in defenders)
            {
                enemy.Damage(defender);
                
                if (!enemy.Alive)
                    break;
            }

            if (enemy.Alive)
                Console.WriteLine($"{enemy.Name} is alive!");

            Console.WriteLine(string.Empty);
        }
    }
}
