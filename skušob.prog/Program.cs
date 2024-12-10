﻿using System;
using System.Drawing;

class Program
{
    static class hraciepole
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
