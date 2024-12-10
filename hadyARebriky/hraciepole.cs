using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hadyARebriky
{
    static class pole
    {
        static char[,] gameBoard = new char[6, 6];

        static void Main()
        {

            InitializeBoard();


            DisplayBoard();


        }
        static void InitializeBoard()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    gameBoard[i, j] = ' ';
                }
            }

        }
        static void DisplayBoard()
        {
            Console.Clear();
            Console.WriteLine("--------------------------");
            for (int i = 0; i < 6; i++)
            {
                Console.Write("| ");
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(gameBoard[i, j] + " | ");
                }
                Console.WriteLine();
                Console.WriteLine("--------------------------");
            }
        }
    }
}