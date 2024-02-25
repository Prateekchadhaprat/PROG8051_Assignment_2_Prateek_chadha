using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG8051_Assignment_2_Prateek_chadha
{
    public class Board
    {
       
        public Cell[,] Grid { get; set; }// Represents the grid of cells


        public Board()
        {
            
            Grid = new Cell[6, 6]; //Creating a 6 by 6 grid cells array

            
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Grid[i, j] = new Cell(GameElement.EMPTY_SPACE);
                }
            }

            
            Grid[0, 0] = new Cell(GameElement.PLAYER_1_ALIAS); //// Setting Player 1 at (0, 0) and Player 2 at (5, 5)
            Grid[5, 5] = new Cell(GameElement.PLAYER_2_ALIAS);

            
            PlaceGems(); // Setting up gems and obstacles
            PlaceObstacles();
        }

       
        private void PlaceGems()
        {
            
            int totalGemsPlaced = 0;
            Random random = new Random(); // Setting random gems in the board using random function
            while (totalGemsPlaced != GameElement.TOTAL_GEM)
            {
                int x = random.Next(0, 6);
                int y = random.Next(0, 6);

                Cell cell = Grid[x, y];

                
                if (cell.Occupant == GameElement.EMPTY_SPACE && cell.Occupant != GameElement.PLAYER_1_ALIAS && cell.Occupant != GameElement.PLAYER_2_ALIAS)
                {
                    Grid[x, y] = new Cell(GameElement.GEM);
                    totalGemsPlaced++;
                }
            }
        }

        
        private void PlaceObstacles()
        {
            
            int totalObstaclesPlaced = 0;
            Random random = new Random();// Placing obstacles randomly until all obstacles are placed on the board
            while (totalObstaclesPlaced != GameElement.TOTAL_OBSTACLE)
            {
                
                int x = random.Next(1, 5);
                int y = random.Next(1, 5);

                Cell cell = Grid[x, y];

                // Condition If the cell is empty and not occupied by a player, place an obstacle
                if (cell.Occupant == GameElement.EMPTY_SPACE && cell.Occupant != GameElement.PLAYER_1_ALIAS && cell.Occupant != GameElement.PLAYER_2_ALIAS)
                {
                    Grid[x, y] = new Cell(GameElement.OBSTACLE);
                    totalObstaclesPlaced++;
                }
            }
        }

        
        public void Display()
        {
            Console.Write("\n"); // display the current state of the board
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Cell currentCell = Grid[i, j];
                    Console.Write(string.Format("{0, -4}", currentCell.Occupant));
                }
                Console.Write("\n");
            }
        }

        
        public bool IsValidMove(Player player, string direction)
        {
            Position position = player.Position;
            int x = position.X;
            int y = position.Y;
            switch (direction)
            {
                case GameMovement.UP:
                    x = Math.Max(0, x - 1);
                    break;
                case GameMovement.DOWN:
                    x = Math.Min(5, x + 1);
                    break;
                case GameMovement.LEFT:
                    y = Math.Max(0, y - 1);
                    break;
                case GameMovement.RIGHT:
                    y = Math.Min(5, y + 1);
                    break;
                default:
                    Console.WriteLine("\nInvalid input. You miss your turn !!!");
                    break;
            }

            
            if (x > 5) x = 5;
            if (y > 5) y = 5;

            
            bool isValidMove = Grid[x, y].Occupant != GameElement.OBSTACLE && !Grid[x, y].Occupant.Contains('P');

            if (isValidMove) //Checking if the move is valid(not an obstacle)
            {
                
                Grid[position.X, position.Y].Occupant = GameElement.EMPTY_SPACE;
            }

            return isValidMove;
        }

        
        public void CollectGem(Player player)
        {
            Position position = player.Position; //Checks and collects gem at the player's position
            if (Grid[position.X, position.Y].Occupant == GameElement.GEM)
            {
                player.GemCount++;
                Console.WriteLine($"\nYay! {player.Name} got a gem.");
            }
            Grid[position.X, position.Y].Occupant = player.Alias;
        }
    }
}
