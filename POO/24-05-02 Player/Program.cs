using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            LocalPlayer B = new LocalPlayer();
            Console.WriteLine("Causando dano");
            B.GetDamage(10);
            B.GetHeal(25);
            B.GetDamage(125);
        }
    }

    class Stats
    {
        public int MaxHealth { get; set; }
        private int health;
        public int Health
        {
            get { return health; }
            set
            {
                if (value < 0)
                    health = 0;
                else if (value > MaxHealth)
                    health = MaxHealth;
                else health = value;
            }
        }
        public Stats(int initialHealth = 100)
        {
            MaxHealth = initialHealth;
            Health = initialHealth;
        }
    }

    class Attributes
    {
        int Strength { get; set; }
    }

    interface Player
    {
        int ID { get; set; }
        string Name { get; set; }
        Stats StatsObj { get; set; }
        Attributes Attributes { get; set; }
    }

    abstract class BasePlayer : Player
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Stats StatsObj { get; set; }
        public Attributes Attributes { get; set; }

        abstract public void GetDamage(int damage);
        abstract public void GetHeal(int cure);
    }

    class LocalPlayer : BasePlayer
    {
        public LocalPlayer()
        {
            StatsObj = new Stats();
        }

        public override void GetDamage(int damage)
        {
            Console.WriteLine($"Damage: {damage} HP: {StatsObj.Health} Result: {StatsObj.Health - damage}");
            StatsObj.Health -= damage;
            Console.WriteLine(StatsObj.Health);
        }
        public override void GetHeal(int cure)
        {
            Console.WriteLine($"Cure: {cure} HP: {StatsObj.Health} Result: {StatsObj.Health + cure}");
            StatsObj.Health += cure;
            Console.WriteLine(StatsObj.Health);
        }
    }
}
