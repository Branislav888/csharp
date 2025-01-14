﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hadyARebriky
{
   public class Kocka
    { 
        public int Hod()
        {
            Random random = new Random();

            while (true)
            {

                int kocka = random.Next(1, 7);
                Console.WriteLine($"Hodené číslo: {kocka}");


                if (kocka == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("  +---------+");
                    Console.WriteLine(" /         /|");
                    Console.WriteLine("+---------+ |");
                    Console.WriteLine("|         | |");
                    Console.WriteLine("|    0    | +");
                    Console.WriteLine("|         |/");
                    Console.WriteLine("+---------+");
                }

                if (kocka == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("  +---------+");
                    Console.WriteLine(" /         /|");
                    Console.WriteLine("+---------+ |");
                    Console.WriteLine("| O       | |");
                    Console.WriteLine("|         | +");
                    Console.WriteLine("|       O |/");
                    Console.WriteLine("+---------+");
                }

                if (kocka == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("  +---------+       ");
                    Console.WriteLine(" /         /|   ");
                    Console.WriteLine("+---------+ |  ");
                    Console.WriteLine("| O       | | ");
                    Console.WriteLine("|    O    | +  ");
                    Console.WriteLine("|       O |/ ");
                    Console.WriteLine("+---------+");
                }

                if (kocka == 4)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("  +---------+");
                    Console.WriteLine(" /         /|");
                    Console.WriteLine("+---------+ |");
                    Console.WriteLine("| O     O | |");
                    Console.WriteLine("|         | +");
                    Console.WriteLine("| O     O |/");
                    Console.WriteLine("+---------+");

                }

                if (kocka == 5)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("  +---------+");
                    Console.WriteLine(" /         /|");
                    Console.WriteLine("+---------+ |");
                    Console.WriteLine("| O     O | |");
                    Console.WriteLine("|    O    | +");
                    Console.WriteLine("| O     O |/");
                    Console.WriteLine("+---------+");
                }

                if (kocka == 6)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("  +---------+");
                    Console.WriteLine(" /         /|");
                    Console.WriteLine("+---------+ |");
                    Console.WriteLine("| O     O | |");
                    Console.WriteLine("| O     O | +");
                    Console.WriteLine("| O     O |/");
                    Console.WriteLine("+---------+");
                }


                Console.WriteLine("Stlačte ENTER na ďalší hod...");
                Console.ReadLine();
            }
        }
    }
}
