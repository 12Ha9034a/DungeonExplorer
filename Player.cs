using System;
using System.Collections.Generic;

namespace DungeonExplorer
{
    public class Player : Creature
    {
        public Inventory Inventory { get; private set; }

        public Player(string name)
        {
            Name = name;
            Health = 100;
            Inventory = new Inventory();
        }

        public override void Attack(Creature target)
        {
            //Player has to use a weapon that is in the inventory
            Console.WriteLine("You cannot attack another player without a weapon! Select a weapon from your inventory");
        }

        public void Heal(int amount)
        {
            Health += amount;
            Console.WriteLine($"{Name} healed for {amount}. Current health: {Health}");
        }
    }
}