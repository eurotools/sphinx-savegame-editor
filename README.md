# Sphinx and the Cursed Mummy Savegame Editor

This application is designed to read and modify saved game files for the PC version of the game **Sphinx and the Cursed Mummy**. It enables users to edit objectives, inventory, and inventory notes, and save the modified data back into a saved game file that can be read by the game.

## Features

- Load Sphinx and the Cursed Mummy saved game files.
- Edit and update game objectives.
- Modify the player's inventory items.
- Add, edit, or delete inventory notes.
- Save the modified game data into a new saved game file.

## Dependencies

This application relies on the `hashcodes.h` file to ensure proper functioning. Before opening any saved game file, make sure to provide the path to the `hashcodes.h` file through the application's configuration.