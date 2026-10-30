using System;
using System.Runtime.CompilerServices;

namespace HeroesGame
{
    class Hero
    {
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
        public int Attack{get;private set;}
        public int Shield{get;private set;}
        public int Health{get;private set;}
        public int BattleWon{get;private set;}
        public int TotalAttacks{get;private set;}
        public string MagicalItem{get;private set;}
        public int MagicalPower{get;private set;}

        Random random = new Random();
        public Hero(string name,int battlesWon,int totalAttacks,string magicalItem,int magicalPower)
        {
            Name = name;
            Attack = random.Next(50, 100);
            Shield = random.Next(50, 100);
            Health = random.Next(50, 100);
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
            System.Console.WriteLine(Name);
            System.Console.WriteLine(Attack);
            System.Console.WriteLine(Shield);
            System.Console.WriteLine(Health);
            System.Console.WriteLine(BattleWon);
        }

        
    }

    class Knight : Hero 
    {
        public Knight()
        {
            
        }
    }
    class Wizard : Hero
    {
        
    }
    class LowRankKnight : Hero
    {
        
    }



    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
