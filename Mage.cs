using System;
using Enemies;

namespace Defenders
{
    class Mage : IDefender
    {
        protected readonly string name;
        protected int mana;
        protected readonly int manaRegen;
        protected readonly int spellPower;


        public Mage(string name, int mana, int manaRegen, int spellPower)
        {
            this.name = name;
            this.mana = mana;
            this.manaRegen = manaRegen;
            this.spellPower = spellPower;
        }

        protected bool CanCastSpell()
        {
            if (mana >= spellPower)
            {
                mana -= spellPower;
                return true;
            }

            Console.WriteLine($"Mage {name} is recharging mana");
            RechargeMana();
            return false;
        }

        private void RechargeMana()
        {
            mana += manaRegen;
        }

        public virtual int AtakGiant(Giant enemy)
        {

            if (CanCastSpell())
            {
                Console.WriteLine($"Mage {name} is attacking");
                Console.WriteLine($"Mage {name} attacked Giant for {spellPower}");
                return spellPower;
            }
            return 0;
        }

        public virtual int AtakOgre(Ogre enemy)
        {

            if (CanCastSpell())
            {
                Console.WriteLine($"Mage {name} is attacking");
                if (spellPower - enemy.Armor > 0)
                {
                    Console.WriteLine($"Mage {name} attacked Ogre for {spellPower - enemy.Armor}");
                    return spellPower - enemy.Armor;
                }
                Console.WriteLine($"Mage {name} attacked Ogre for 1");
                return 1;
            }
            return 0;
        }

        public virtual int AtakRat(Rat enemy)
        {
            if (CanCastSpell())
            {
                Console.WriteLine($"Mage {name} is attacking");
                Console.WriteLine($"Mage {name} attacked Rat for {spellPower}");
                return spellPower;
            }
            return 0;
        }
    }
}