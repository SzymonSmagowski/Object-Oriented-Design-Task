using System;
using Enemies;

namespace Defenders
{
    class FireMage : Mage
    {
        private double killChance;
        protected static readonly Random rng = new Random(1597);

        public FireMage(string name, int mana, int manaRegen, int spellPower, double killChance) : base(name, mana, manaRegen, spellPower)
        {
            this.killChance = killChance;
        }

        public override int AtakGiant(Giant enemy)
        {

            if (!(rng.NextDouble() < killChance))
            {
                if (CanCastSpell())
                {
                    Console.WriteLine($"Fire mage {name} is attacking");
                    Console.WriteLine($"Fire mage {name} attacked Giant for {spellPower}");
                    return spellPower;
                }
                return 0;
            }
            Console.WriteLine($"Fire mage {name} is attacking");
            Console.WriteLine($"Fire mage {name} does a deadly hit to Giant for {enemy.HP}!");
            return enemy.HP;
        }

        public override int AtakOgre(Ogre enemy)
        {

            if (!(rng.NextDouble() < killChance))
            {
                if (CanCastSpell())
                {
                    if (spellPower - enemy.Armor > 0)
                    {
                        Console.WriteLine($"Fire mage {name} attacked Ogre for {spellPower - enemy.Armor}");
                        return spellPower - enemy.Armor;
                    }
                    Console.WriteLine($"Fire mage {name} attacked Ogre for 1");
                    return 1;
                }
                return 0;
            }
            Console.WriteLine($"Fire mage {name} is attacking");
            Console.WriteLine($"Fire mage {name} does a deadly hit to Ogre for {enemy.HP}!");
            return enemy.HP;
        }

        public override int AtakRat(Rat enemy)
        {
            if (!(rng.NextDouble() < killChance))
            {
                if (CanCastSpell())
                {
                    Console.WriteLine($"Fire mage {name} is attacking");
                    Console.WriteLine($"Fire mage {name} attacked Rat for {spellPower}");
                    return spellPower;
                }
                return 0;
            }
            Console.WriteLine($"Fire mage {name} is attacking");
            Console.WriteLine($"Fire mage {name} does a deadly hit to Rat for {enemy.HP}!");
            return enemy.HP;
        }
    }
}