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
        public int _TotalAttacks{get;private set;}
        public string MagicalItem{get;private set;}
        public int MagicalPower{get;private set;}
    }
    class Knight : Hero
    {
        
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
