namespace SpiderGame
{
    class Enemy
    {
        public string Name { get; set; }
        public int Health { get; set; } = 50;

        public Enemy(string name)
        {
            Name = name;
        }
    }
}