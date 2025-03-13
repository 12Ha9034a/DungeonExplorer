# Dungeon Explorer

A simple text-based dungeon adventure game written in Python.

📜 Overview

Dungeon Explorer is a text-based adventure game where players navigate through different rooms, collect items, and avoid traps while keeping track of their health. The game follows Object-Oriented Programming (OOP) principles, ensuring modularity and efficiency.

📂 Project Structure

bash

Copy

Edit

DungeonExplorer/

│── game.py        # Main game logic

│── player.py      # Player class (tracks health, inventory)

│── room.py        # Room class (handles room descriptions & items)

│── main.py        # Entry point of the game

│── README.md      # Project documentation

# 🎮 Game Instructions

You start at the dungeon entrance.

Move between rooms using the "move" command.

Collect items when prompted.

Avoid traps and manage your health.

Type "quit" to exit the game.

# 🛠 OOP Features Implemented

1️⃣ Encapsulation
Player attributes like health and inventory are private (__health, __inventory).
Getter and setter methods control access to private attributes.

2️⃣ Abstraction
Game, Player, and Room classes hide unnecessary details from the user.
The play() method in Game manages the game loop without exposing complex logic.

3️⃣ Inheritance (Optional Feature)
If subclasses are added (e.g., Enemy class extending Player), they inherit behaviors and override methods.

4️⃣ Methods & Constructors
Player Class:
pick_up_item(item): Adds an item to the player's inventory.
reduce_health(amount): Decreases player health upon encountering a trap.
Room Class:
get_description(): Returns the room's description.

5️⃣ Error Handling
Prevents players from entering rooms that do not exist.
Manages invalid user inputs.
