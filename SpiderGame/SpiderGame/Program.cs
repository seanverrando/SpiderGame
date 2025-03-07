using System;
using System.Numerics;

namespace SpiderGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your character's name: ");
            string playerName = Console.ReadLine();

            Player player = new Player(playerName);
            Enemy spider = new Enemy("Giant Spider");

            Console.WriteLine($"A wild {spider.Name} appears!");

            while (spider.Health > 0)
            {
                player.Attack(spider);
                Console.WriteLine($"{spider.Name} has {spider.Health} HP left.");
                if (spider.Health <= 0)
                {
                    Console.WriteLine($"{spider.Name} has been defeated!");
                }
                Console.ReadLine(); // Pause for effect
            }
        }
    }
}