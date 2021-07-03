using System;
using Defenders;

namespace Enemies
{
    abstract class Enemy
    {
        public string Name { get; }

        public char Type { get; set; }

        public bool Alive { get; private set; }
        public int HP { get; private set; } 

        protected Enemy(string name, int hp)
        {
            Name = name;
            HP = hp;
            Alive = true;
        }

        protected void GetDamage(int? damage)
        {
            HP -= damage.Value;
            if (HP <= 0)
            {
                Console.WriteLine($"{Name} is dead...");
                Alive = false;
            }
        }
        public abstract void Damage(IDefender defender);
        
    }
    class Giant : Enemy
    {

        public Giant(string name, int hp) : base(name, hp)
        {
            
        }

        public override void Damage(IDefender defender)
        {
            this.GetDamage(defender.AtakGiant(this));
        }

    }

    class Ogre : Enemy
    {
        public int Armor { get; }

        public Ogre(string name, int hp, int armor) : base(name, hp)
        {
            Armor = armor;
            
        }

        public override void Damage(IDefender defender)
        {
            this.GetDamage(defender.AtakOgre(this));
        }
    }

    class Rat : Enemy
    {
        public int Speed { get; private set; }

        public Rat(string name, int hp, int speed) : base(name, hp)
        {
            Speed = speed;
            
        }
        public void IncreaseSpeed()
        {
            Speed++;
        }

        public override void Damage(IDefender defender)
        {
            this.GetDamage(defender.AtakRat(this));
        }
    }
}