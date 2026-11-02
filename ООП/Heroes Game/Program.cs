using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime;
using System.Runtime.CompilerServices;

namespace HeroesGame
{
    class Hero
    {
        protected static Random random = new Random();

        // name, attack, shield, health, battlesWon, totalAttacks, magicalItem и magicalPower
        private string _name;
        private int _attack;
        private int _shield;
        private int _health;
        private int _battleWon;
        private int _totalAttacks;
        private string _magicalItem;
        private int magicalPower;

        public string Name{get;private set;}
        public int AttackPower{get;private set;}
        public int Shield{get;private set;}
        public int Health{get;private set;}
        public int BattleWon{get;private set;}
        public int TotalAttacks{get;private set;}
        public string MagicalItem{get;private set;}
        public int MagicalPower{get;private set;}
        public int InitialHealth{get;private set;}
        public Hero(string name,int battlesWon,int totalAttacks,string magicalItem,int magicalPower)
        {
            Name = name;
            AttackPower = random.Next(50, 100);
            Shield = random.Next(50, 100);
            Health = random.Next(50, 100);
            InitialHealth = Health;
            BattleWon = 0;
            TotalAttacks = 0;
            MagicalItem = "";
            MagicalPower = 0;
        }
        public Hero():this("noname", 0, 0, " ", 0)
        {
            
        }
        public virtual void Show()
        {
            Console.WriteLine(Name);
            System.Console.WriteLine(AttackPower);
            System.Console.WriteLine(Shield);
            System.Console.WriteLine(Health);
            System.Console.WriteLine(BattleWon);
        }
        public bool Attack(Hero target)
        {
            if(this.Health == 0 || target.Health == 0)
            {
                return false;
            }
            else
            {
                int before = target.Health;
                TotalAttacks += 1;
                int damage = Math.Max(0,AttackPower + Shield - target.Shield);
                target.Health = Math.Max(0, target.Health - damage);
                if(before > 0 && target.Health == 0)
                {
                    BattleWon += 1;
                }
                return true;
            }
            
        }
        public int CalculateBatttleWon()
        {
            return BattleWon;
        }
        public void ShowExperience()
        {
            Console.WriteLine(TotalAttacks + BattleWon);
        }

        static Hero Duel(Hero hero1, Hero hero2)
        {
            if(hero1.Attack(hero2) == 0 && hero2.Attack(hero1) == 0)
            {
                return null;
            }
            Hero attacker = hero1;
            Hero defender = hero2;
            while (hero1.Health > 0 && hero2.Health > 0)
            {
                int dmg = attacker.Attack(defender);
                bool won = attacker.Attack(defender);
                if (won)
                {
                    return attacker;
                }
                (attacker, defender) = (defender, attacker);
            }
        }
    }

    class Knight : Hero 
    {

        public Knight(string name,int battlesWon,int totalAttacks,string magicalItem,int magicalPower):base(name, battlesWon, totalAttacks, magicalItem, magicalPower)
        {
            
        }
        public override void Show()
        {
            base.Show();
            if(MagicalItem != null && MagicalPower != 0)
            {
                System.Console.WriteLine($"MI = {MagicalItem}");
                System.Console.WriteLine($"MP = {MagicalPower}");

            }
        }
        
    }
    class Wizard : Hero
    {
        public Wizard(string name, string item) : base(name)
        {
            string magicalItem = item;
            Random random = new Random();
            int magicalPower = random.Next(1, 100);
        }
        public override void Show()
        {
            base.Show();
            if(MagicalItem != null && MagicalPower != 0)
            {
                System.Console.WriteLine($"MI = {MagicalItem}");
                System.Console.WriteLine($"MP = {MagicalPower}");

            }
        }
        public void UseMagicalItem()
        {
            if(MagicalItem != null && MagicalPower != 0)
            {
                System.Console.WriteLine($"{Name} uses: {MagicalItem} with power: {MagicalPower}");
            }
            else
            {
                System.Console.WriteLine($"{Name} don't use magical item");
            }
        }
    }
    class LowRankKnight : Knight
    {
        public LowRankKnight(string name,int battlesWon,int totalAttacks,string magicalItem,int magicalPower):base(name, battlesWon, totalAttacks, magicalItem, magicalPower)
        {
            
        }
        public override void Show()
        {
            base.Show();
        }
    }
        

    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
