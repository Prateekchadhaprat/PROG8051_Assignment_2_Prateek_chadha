using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG8051_Assignment_2_Prateek_chadha

/*{
    internal class Program
    {
        static void displayBoard(string[,] Board)
        {
            for (int i = 0; i < Board.GetLength(0); i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < Board.GetLength(1); j++)
                {
                    Console.Write(Board[i, j] + "  ");
                }
            }
        }

        static void getTurn(int turn)
        {
            if (turn % 2 == 0)
            {
                Console.WriteLine("\nPlayer 1's turn: ");
            }
            else
            {
                Console.WriteLine("\nPlayer 2's turn: ");
            }
        }

        static string GetPosition(string userposition)
        {
            int r = 0;
            int c = 0;

            switch (userposition)
            {
                case "1":
                    r = 0;
                    c = 0;
                    break;
                case "2":
                    r = 0;
                    c = 1;
                    break;
                case "3":
                    r = 0;
                    c = 2;
                    break;
                case "4":
                    r = 0;
                    c = 3;
                    break;
                case "5":
                    r = 0;
                    c = 4;
                    break;
                case "6":
                    r = 0;
                    c = 5;
                    break;
                case "7":
                    r = 1;
                    c = 0;
                    break;
                case "8":
                    r = 1;
                    c = 1;
                    break;
                case "9":
                    r = 1;
                    c = 2;
                    break;
                case "10":
                    r = 1;
                    c = 3;
                    break;
                case "11":
                    r = 1;
                    c = 4;
                    break;
                case "12":
                    r = 1;
                    c = 5;
                    break;
                case "13":
                    r = 2;
                    c = 0;
                    break;
                case "14":
                    r = 2;
                    c = 1;
                    break;
                case "15":
                    r = 2;
                    c = 2;
                    break;
                case "16":
                    r = 2;
                    c = 3;
                    break;
                case "17":
                    r = 2;
                    c = 4;
                    break;
                case "18":
                    r = 2;
                    c = 5;
                    break;
                case "19":
                    r = 3;
                    c = 0;
                    break;
                case "20":
                    r = 3;
                    c = 1;
                    break;
                case "21":
                    r = 3;
                    c = 2;
                    break;
                case "22":
                    r = 3;
                    c = 3;
                    break;
                case "23":
                    r = 3;
                    c = 4;
                    break;
                case "24":
                    r = 3;
                    c = 5;
                    break;
                case "25":
                    r = 4;
                    c = 0;
                    break;
                case "26":
                    r = 4;
                    c = 1;
                    break;
                case "27":
                    r = 4;
                    c = 2;
                    break;
                case "28":
                    r = 4;
                    c = 3;
                    break;
                case "29":
                    r = 4;
                    c = 4;
                    break;
                case "30":
                    r = 4;
                    c = 5;
                    break;
                case "31":
                    r = 5;
                    c = 0;
                    break;
                case "32":
                    r = 5;
                    c = 1;
                    break;
                case "33":
                    r = 5;
                    c = 2;
                    break;
                case "34":
                    r = 5;
                    c = 3;
                    break;
                case "35":
                    r = 5;
                    c = 4;
                    break;
                case "36":
                    r = 5;
                    c = 5;
                    break;
            }
            return r.ToString() + " " + c.ToString();
        }

        static int userinput(string[,] Board, int r, int c, int turn)
        {


            if (turn % 2 == 0)
            {
                Board[r, c] = "P1";
            }
            else
            {
                Board[r, c] = "P2";
            }
            turn++;
            return turn;
        }
*/
//static bool checkWinner(string[,] Board)
//{

//}
{
    internal class Program
    {
        // Main Method 
        static public void Main(string[] args)
        {
            Console.WriteLine("\nGet ready to hunt Gems!!\n");


            Console.Write("Enter player 1 name : ");
            string player1Name = Console.ReadLine() ?? GameElement.PLAYER_1_ALIAS;

            Console.Write("\nEnter player 2 name : ");
            string player2Name = Console.ReadLine() ?? GameElement.PLAYER_2_ALIAS;


            Game game = new Game(player1Name, player2Name);
            game.Start();

            Console.WriteLine("\nThank you for playing the game.");
        }
    }

   

    //        string pos = GetPosition(userposition);

    //        int r = Convert.ToInt32(pos.Split()[0]);
    //        int c = Convert.ToInt32(pos.Split()[1]);
    //        if (Board[r, c] != "-")
    //        {
    //            continue;
    //        }

    //        turn = userinput(Board, r, c, turn);
    //        displayBoard(Board);



    //        //bool winner = checkWinner(Board);
    //        //if (winner)
    //        //{
    //        //    Console.WriteLine("Game ended");
    //        //    break;
    //        //}



    //    }
    //}
}
