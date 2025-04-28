using System;

namespace DungeonExplorer
{
    public abstract class Creature
    {
        public string Name { get; protected set; }
        public int Health { get; protected set; }

        public virtual void Attack(Creature target)
        {
            Console.WriteLine($"{Name} attacks {target.Name}");
        }
    }
}