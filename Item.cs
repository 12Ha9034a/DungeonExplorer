using System;

namespace DungeonExplorer
{
    public interface ICollectible
    {
        string Name { get; }
        string Description { get; }
        void Use(Player player);
    }

    public abstract class Item : ICollectible
    {
        public string Name { get; protected set; }
        public string Description { get; protected set; }

        public abstract void Use(Player player);
    }

    public class Weapon : Item
    {
        public int Damage { get; set; }

        public Weapon(string name, string description, int damage)
        {
            Name = name;
            Description = description;
            Damage = damage;
        }

        public override void Use(Player player)
        {
            Console.WriteLine($"You swing the {Name}!");
        }
    }

    public class Potion : Item
    {
        public int HealingAmount { get; set; }

        public Potion(string name, string description, int healingAmount)
        {
            Name = name;
            Description = description;
            HealingAmount = healingAmount;
        }

        public override void Use(Player player)
        {
            Console.WriteLine($"You drink the {Name}. You heal for {HealingAmount} health.");
            player.Heal(HealingAmount);
        }
    }
}