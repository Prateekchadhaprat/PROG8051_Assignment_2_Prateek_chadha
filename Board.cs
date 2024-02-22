using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG8051_Assignment_2_Prateek_chadha
{
    public class Board
    {
       
        public Cell[,] Grid { get; set; }

        
        public Board()
        {
            
            Grid = new Cell[6, 6];

            
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Grid[i, j] = new Cell(GameElement.EMPTY_SPACE);
                }
            }

            
            Grid[0, 0] = new Cell(GameElement.PLAYER_1_ALIAS);
            Grid[5, 5] = new Cell(GameElement.PLAYER_2_ALIAS);

            
            PlaceGems();
            PlaceObstacles();
        }

       
        private void PlaceGems()
        {
            
            int totalGemsPlaced = 0;
            Random random = new Random();
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
            Random random = new Random();
            while (totalObstaclesPlaced != GameElement.TOTAL_OBSTACLE)
            {
                
                int x = random.Next(1, 5);
                int y = random.Next(1, 5);

                Cell cell = Grid[x, y];

                
                if (cell.Occupant == GameElement.EMPTY_SPACE && cell.Occupant != GameElement.PLAYER_1_ALIAS && cell.Occupant != GameElement.PLAYER_2_ALIAS)
                {
                    Grid[x, y] = new Cell(GameElement.OBSTACLE);
                    totalObstaclesPlaced++;
                }
            }
        }

        
        public void Display()
        {
            Console.Write("\n");
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

            if (isValidMove)
            {
                
                Grid[position.X, position.Y].Occupant = GameElement.EMPTY_SPACE;
            }

            return isValidMove;
        }

        
        public void CollectGem(Player player)
        {
            Position position = player.Position;
            if (Grid[position.X, position.Y].Occupant == GameElement.GEM)
            {
                player.GemCount++;
                Console.WriteLine($"\nYeah! {player.Name} got a gem.");
            }
            Grid[position.X, position.Y].Occupant = player.Alias;
        }
    }
}
