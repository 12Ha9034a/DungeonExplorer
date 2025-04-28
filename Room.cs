using System;

namespace DungeonExplorer
{
    class Room
    {
        private string _description;
        public ICollectible Item { get; set; }

        public Room(string description, ICollectible item = null)
        {
            _description = description;
            Item = item;
        }

        public string GetDescription()
        {
            return _description;
        }

        public ICollectible GetItem()
        {
            return Item;
        }

        public void RemoveItem()
        {
            Item = null;
        }
    }
}