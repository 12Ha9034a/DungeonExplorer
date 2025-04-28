using System.Collections.Generic;

namespace DungeonExplorer
{
    class GameMap
    {
        private Dictionary<string, Room> _rooms = new Dictionary<string, Room>();
        public string CurrentRoom { get; set; }

        public GameMap()
        {
            CreateRooms();
            CurrentRoom = "Entrance"; // Starting Room
        }

        private void CreateRooms()
        {
            _rooms["Entrance"] = new Room("You are at the dungeon entrance.", new Weapon("Rusty Sword", "A basic weapon.", 10));
            _rooms["Hall"] = new Room("A long, dark hallway with flickering torches.", new Potion("Healing Potion", "Restores some health.", 20));
            _rooms["Treasure Room"] = new Room("A bright room filled with gold and jewels.", new Weapon("Golden Axe", "A very powerful axe", 40));
        }

        public Room GetRoom(string roomName)
        {
            if (_rooms.ContainsKey(roomName))
            {
                return _rooms[roomName];
            }
            return null;
        }

        public bool RoomExists(string roomName)
        {
            return _rooms.ContainsKey(roomName);
        }
    }
}