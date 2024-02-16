using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG8051_Assignment_2_Prateek_chadha
{
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
                    r = 1;
                    c = 0;
                    break;
                case "5":
                    r = 1;
                    c = 1;
                    break;
                case "6":
                    r = 1;
                    c = 2;
                    break;
                case "7":
                    r = 2;
                    c = 0;
                    break;
                case "8":
                    r = 2;
                    c = 1;
                    break;
                case "9":
                    r = 2;
                    c = 2;
                    break;


            }
            return r.ToString() + " " + c.ToString();
        }





        static void Main(string[] args)
        {
            // 6*6 Board

            string[,] Board = { { "-", "-", "-", "-", "-", "-" }, { "-", "-", "-", "-", "-", "-" }, { "-", "-", "-", "-", "-", "-" },{ "-", "-", "-", "-", "-", "-" },{ "-", "-", "-", "-", "-", "-" },{ "-", "-", "-", "-", "-", "-" }

                displayBoard(Board);



            int turn = 0;
        }
    }
}
