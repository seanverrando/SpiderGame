using System;

namespace SpiderGame
{
    class Player
    {
        public string Name { get; set; }
        public int Health { get; set; } = 100;
        public int AttackPower { get; set; } = 10;

        public Player(string name)
        {
            Name = name;
        }

        public void Attack(Enemy enemy)
        {
            Console.WriteLine($"{Name} attacks {enemy.Name} for {AttackPower} damage!");
            enemy.Health -= AttackPower;
        }
    }
}