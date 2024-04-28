# Checkers Game
Welcome to the Checkers Game repository! This is a WPF (Windows Presentation Foundation) application developed in C# that brings the classic game of checkers to life with a graphical user interface. The application follows the MVVM (Model-View-ViewModel) architectural pattern for clean and organized code.

## Overview
The Checkers Game features the following functionalities:

- **Gameplay**: Players take turns moving their pieces on an 8x8 checkerboard. The player with red pieces moves first, followed by alternating turns between players.
- **Piece Movement**: Players can make simple moves by moving their pieces diagonally forward one square. If a piece reaches the opponent's back row, it becomes a "king" and gains the ability to move diagonally backward as well.
- **Capture Moves**: Players can capture their opponent's pieces by jumping over them diagonally. Captured pieces are removed from the board.
- **Multiple Jumps**: If a player's piece can make another capture move after landing from a previous jump, they must do so. This process can continue with multiple consecutive jumps until no more captures are possible.
- **Game End**: The game ends when one player has no more pieces remaining on the board. The opponent is declared the winner.

## Features
- **MVVM Architecture**: The application follows the MVVM pattern for structured and maintainable code.
- **Save and Load Game State**: Players can save the current game state to a file and load it later to resume play. The file contains the game state and the player's turn.
- **Customizable Game Settings**: Players can choose various game settings such as allowing multiple jumps, piece types (regular or king), and more.
- **Statistics**: The application keeps track of the number of games won by each player and the maximum number of pieces remaining on the board at the end of a game. These statistics are displayed in the application and saved to a file.

## Getting Started
To get started with the Checkers Game, follow these steps:

1. **Clone the Repository**: Clone this repository to your local machine.
   ```bash
   git clone https://github.com/alexandru-pestritu/WPF_Checkers
   ```
2. **Open in Visual Studio**: Open the solution file (Wpf_Checkers.sln) in Visual Studio.
3. **Build and Run**: Build the solution and run the application to start playing checkers.
   
