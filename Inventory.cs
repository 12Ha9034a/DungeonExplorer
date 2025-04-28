using System;
using System.Collections.Generic;
using System.Linq;

namespace DungeonExplorer
{
    public class Inventory
    {
        private List<ICollectible> _items = new List<ICollectible>();

        public void AddItem(ICollectible item)
        {
            _items.Add(item);
            Console.WriteLine($"Added {item.Name} to inventory.");
        }

        public void RemoveItem(ICollectible item)
        {
            _items.Remove(item);
            Console.WriteLine($"Removed {item.Name} from inventory.");
        }

        public void ListItems()
        {
            if (_items.Count == 0)
            {
                Console.WriteLine("Inventory is empty.");
                return;
            }

            Console.WriteLine("Inventory:");
            foreach (var item in _items)
            {
                Console.WriteLine($"- {item.Name}: {item.Description}");
            }

            Console.WriteLine("\nWeapons Only:");
            foreach (var weapon in _items.OfType<Weapon>())
            {
                Console.WriteLine($"- {weapon.Name}: Damage - {weapon.Damage}");
            }
        }

        public ICollectible GetItem(string itemName)
        {
            return _items.FirstOrDefault(item => item.Name.ToLower() == itemName.ToLower());
        }
    }
}