using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG8051_Assignment_2_Prateek_chadha
{
    public class Player
    {
        
        public string Name { get; set; }
        
        public string Alias { get; set; }
        
        public Position Position { get; set; }
        
        public int GemCount { get; set; }

        
        public Player(string name, string alias, Position position)
        {
            Name = name;
            Alias = alias;
            Position = position;
            GemCount = 0;

            public void Move(string direction)
            {
                int x = Position.X;
                int y = Position.Y;

                // Update coordinates based on the direction
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
                        Console.WriteLine("Invalid input. You miss your turn !!!");
                        break;
                }

                
                if (x > 5) x = 5;
                if (y > 5) y = 5;

                
                Position = new Position(x, y);
            }
        }
    }
}