using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG8051_Assignment_2_Prateek_chadha
{
    public class Game
    {
        public Board Board { get; set; }
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        public Player CurrentPlayerTurn { get; set; }
        public int TotalTurns { get; set; }

        
        public Game(string player1Name, string player2Name)
        {
            
            Player1 = new Player(player1Name, GameElement.PLAYER_1_ALIAS, new Position(0, 0));

            
            Player2 = new Player(player2Name, GameElement.PLAYER_2_ALIAS, new Position(5, 5));

            
            TotalTurns = 0;

            
            CurrentPlayerTurn = Player1;

            
            Board = new Board();
        }

        
        public void Start()
        {
            
            Board.Display();
            {
            }
        }
    }
}