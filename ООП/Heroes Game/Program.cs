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
        public int Health{get;protected set;}
        public int BattleWon{get;private set;}
        public int TotalAttacks{get;private set;}
        public string MagicalItem{get;protected set;}
        public int MagicalPower{get;protected set;}
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
        public Hero(string name):this(name, 0, 0, "", 0)
        {

        }
        protected Hero(Hero other)
        {
            Name = other.Name;
            AttackPower = other.AttackPower;
            Shield = other.Shield;
            Health = other.Health;
            InitialHealth = other.InitialHealth;
            BattleWon = other.BattleWon;
            TotalAttacks = other.TotalAttacks;
            MagicalItem = other.MagicalItem;
            MagicalPower = other.MagicalPower;
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
                int damage = CalculateDamage(target);
                target.Health = Math.Max(0, target.Health - damage);
                if(before > 0 && target.Health == 0)
                {
                    BattleWon += 1;
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
        public int CalculateDamage(Hero target)
        {
            return Math.Max(0, AttackPower + Shield - target.Shield);
        }
        public void RestoreHealth()
        {
            Health = InitialHealth;
        }
        public int CalculateBatttleWon()
        {
            return BattleWon;
        }
        public void ShowExperience()
        {
            Console.WriteLine(TotalAttacks + BattleWon);
        }

        public static Hero Duel(Hero hero1, Hero hero2)
        {
            // Ако и двамата нанасят 0 щета, двубоят е равен
            if(hero1.CalculateDamage(hero2) == 0 && hero2.CalculateDamage(hero1) == 0)
            {
                Console.WriteLine("Равенство: и двамата нанасят 0 щета.");
                return null;
            }
            Hero attacker = hero1;
            Hero defender = hero2;
            while (hero1.Health > 0 && hero2.Health > 0)
            {
                int dmg = attacker.CalculateDamage(defender);
                bool won = attacker.Attack(defender);
                Console.WriteLine($"{attacker.Name} нанася {dmg} щета. {defender.Name} има {defender.Health} здраве.");
                if (won)
                {
                    Console.WriteLine($"Победител: {attacker.Name}");
                    return attacker;
                }
                (attacker, defender) = (defender, attacker);
            }
            return null;
        }

        public void TakeMagicFrom(Hero loser)
        {
            MagicalItem = loser.MagicalItem;
            MagicalPower = loser.MagicalPower;
            loser.MagicalItem = "";
            loser.MagicalPower = 0;
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
        public Knight(string name) : base(name) { }
        public Knight(Hero other) : base(other) { }
        
    }
    class Wizard : Hero
    {
        public Wizard(string name, string item) : base(name)
        {
            MagicalItem = item;
            MagicalPower = random.Next(1, 100);
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
        public bool BattleForKnight(LowRankKnight otherKnight)
        {
            Health = InitialHealth;         
            Hero winner = Duel(this, otherKnight);
            return winner == this;
        }
        public LowRankKnight(string name) : base(name) { }
        public Knight PromoteToKnight()
        {
        if (BattleWon < 3)
            throw new InvalidOperationException("Нужни са 3 победи за рицарско звание.");
        return new Knight(this);
        }

    }
        

    class Program
    {
        static void Main(string[] args)
        {
            LowRankKnight candidate = new LowRankKnight("Кандидат");
            Knight playerKnight = null;   // попълва се след повишаването

            while (true)
            {
                Console.WriteLine("1 - Рицар срещу магьосник");
                Console.WriteLine("2 - Двубой за рицарско звание");
                Console.WriteLine("0 - Край");
                string choice = Console.ReadLine();

                if (choice == "0") break;
                else if (choice == "1")
                {
                    // След повишаването играта продължава с върнатия рицар
                    Knight knight;
                    if (playerKnight != null)
                    {
                        playerKnight.RestoreHealth();
                        knight = playerKnight;
                    }
                    else
                    {
                        knight = new Knight("Рицар");
                    }

                    Wizard wizard = new Wizard("Магьосник", "Жезъл");
                    wizard.UseMagicalItem();

                    Hero winner = Hero.Duel(knight, wizard);
                    if (winner == knight)
                    {
                        knight.TakeMagicFrom(wizard);
                    }
                    knight.Show();
                    wizard.Show();
                }
                else if (choice == "2")
                {
                    if (playerKnight != null)
                    {
                        Console.WriteLine("Вече имаш рицарско звание.");
                        playerKnight.Show();
                    }
                    else
                    {
                        LowRankKnight opponent = new LowRankKnight("Противник");
                        bool won = candidate.BattleForKnight(opponent);
                        if (won)
                        {
                            Console.WriteLine($"Спечели двубоя. Победи: {candidate.CalculateBatttleWon()} от 3");
                        }
                        else
                        {
                            Console.WriteLine($"Няма победа. Победи: {candidate.CalculateBatttleWon()} от 3");
                        }

                        if (candidate.CalculateBatttleWon() >= 3)
                        {
                            playerKnight = candidate.PromoteToKnight();
                            Console.WriteLine("Получи рицарско звание!");
                            playerKnight.Show();
                        }
                    }
                }
                else Console.WriteLine("Невалиден избор.");
            }
        }
    }
}
