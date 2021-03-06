﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Phase 1: setup
            //      A: Computer asks user to enter coords for each type of ship one at a time:
            //          0) Computer draws game grid
            //          1) PT Cruiser, Sub, Destroyer, Battleship, Carrier
            //          2) User enters starting cell
            //          3) Computer asks which direction the ship will sit - and gives list of options
            //          4) User enters direction and computer draws on grid
            //          5) When all ships are placed, then computer confirms setup
            //              a. If user confirms, game goes to Play phase
            //              b. If user declines, game returns to Setup phase step 1
            // Phase 2: play
            var top    = "┌─┬─┬─┬─┬─┬─┬─┬─┬─┬─┐";
            var empty  = "│ │ │ │ │ │ │ │ │ │ │";
            var middle = "├─┼─┼─┼─┼─┼─┼─┼─┼─┼─┤";
            var bottom = "└─┴─┴─┴─┴─┴─┴─┴─┴─┴─┘";
            Console.SetCursorPosition(Console.WindowWidth - 21, 0);
            Console.Write(top);
            for (int i = 1; i <19; i+=2)
            {
                Console.SetCursorPosition(Console.WindowWidth - 21, i);
                Console.Write(empty);
                //for (int j = 2; j < 10; j++)
                //{
                    Console.SetCursorPosition(Console.WindowWidth - 21, i+1);
                    Console.Write(middle);
                //}
            }

            // Console.ReadKey();
            //Console.SetCursorPosition(Console.WindowWidth - 21, 1);
            //Console.Write(empty);
            //Console.SetCursorPosition(Console.WindowWidth - 21, 2);
            //Console.Write(middle);
            Console.SetCursorPosition(Console.WindowWidth - 21, 19);
            Console.Write(empty);
            Console.SetCursorPosition(Console.WindowWidth - 21, 20);
            Console.Write(bottom);
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                for (int j = 0; j < Console.WindowHeight; j++)
                {
                    //Console.SetCursorPosition(i, j);
                    
                }  
            }
            Console.ReadKey();
        }
    }
}
