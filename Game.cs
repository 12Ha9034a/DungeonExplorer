using System;

namespace DungeonExplorer
{
    class Game
    {
        private Player _player;
        private GameMap _gameMap;

        public Game()
        {
            _gameMap = new GameMap();
        }

        public void Start()
        {
            Console.WriteLine("Welcome to Dungeon Explorer!");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            _player = new Player(name);
            Play();
        }

        private void Play()
        {
            Console.WriteLine($"\n{_player.Name}, you are entering the dungeon!");

            while (true)
            {
                Room currentRoom = _gameMap.GetRoom(_gameMap.CurrentRoom);

                Console.WriteLine($"\n{currentRoom.GetDescription()}");
                _player.Inventory.ListItems();

                ICollectible item = currentRoom.GetItem();
                if (item != null)
                {
                    Console.WriteLine($"You see a {item.Name} in the room.");
                    Console.Write("Do you want to pick it up? (yes/no): ");
                    string pick = Console.ReadLine().ToLower();

                    if (pick == "yes")
                    {
                        _player.Inventory.AddItem(item);
                        currentRoom.RemoveItem();
                    }
                }

                Console.Write("Type 'move' to go to another room, 'use' to use an item, or 'quit' to exit: ");
                string action = Console.ReadLine().ToLower();

                if (action == "move")
                {
                    Console.Write("Enter the room name (Hall/Treasure Room): ");
                    string nextRoom = Console.ReadLine();

                    if (_gameMap.RoomExists(nextRoom))
                    {
                        _gameMap.CurrentRoom = nextRoom;
                    }
                    else
                    {
                        Console.WriteLine("You cannot enter a room that doesn't exist! Try again.");
                    }
                }
                else if (action == "use")
                {
                    Console.Write("Enter the name of the item to use: ");
                    string itemName = Console.ReadLine();
                    ICollectible itemToUse = _player.Inventory.GetItem(itemName);

                    if (itemToUse != null)
                    {
                        itemToUse.Use(_player);  // Use the item
                        if (itemToUse is Potion)
                        {
                            _player.Inventory.RemoveItem(itemToUse);
                        }
                    }
                    else
                    {
                        Console.WriteLine("You don't have that item in your inventory.");
                    }
                }
                else if (action == "quit")
                {
                    Console.WriteLine("Exiting the game. Goodbye!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid command! Use 'move', 'use', or 'quit'.");
                }
            }
        }
    }
}