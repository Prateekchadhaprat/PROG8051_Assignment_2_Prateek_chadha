# PROG8051_Assignment_2_Prateek_chadha

Please find the below zoom video link for the output of the game 
https://conestogac.zoom.us/rec/share/yNeH6jzsKSYSwsre9aZ9JLH1pS3jiNuS6SK67BU0xXv-Gihss0UJahUVMtGgk79R.HDfeDL8IlFGiDp8s?startTime=1708868438000

A console-based 2D game called "Gem Hunters" where players compete to collect the most gems within a set number of turns.

Board Size:
A 6x6 square board.

Game Elements:
Players: Player 1 starts in the top-left corner, and Player 2 starts in the bottom-right corner.
Gems: Randomly placed on the board at the start of the game. They do not move once established.
Obstacles: Random positions on the board (e.g., represented by an "O") that players cannot pass through.
Rules:
Display: The board will be displayed after every turn. Players will be represented by P1 and P2, gems by G, obstacles by O, and empty spaces by -.

Movement:

Players input their movement through the console: U for up, D for down, L for left, R for right.
Players can move up, down, left, or right by one square on their turn.
Players cannot move diagonally.
Players cannot move onto or through squares with obstacles.
Collecting Gems:

If a player moves onto a square containing a gem, they collect it. The gem is removed from the board (the square becomes a space).
Turns:

Players alternate turns. Each player gets 15 turns. The game ends after 30 moves (15 turns for each player).
Winning:

The player with the most gems collected after all turns are exhausted wins. If both players have the same number of gems, it's a tie.
