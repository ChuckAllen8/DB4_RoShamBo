using System;
using System.Collections.Generic;
using System.Text;

namespace DB4_RoShamBo
{
    public class Validator
    {
        public string GetYN()
        {
            Console.Write("Play Again? ");
            ConsoleKey choice = Console.ReadKey().Key;
            Console.WriteLine();

            if(choice == ConsoleKey.Y)
            {
                return "Y";
            }
            else if (choice == ConsoleKey.N)
            {
                return "N";
            }
            else
            {
                return GetYN();
            }
        }

        public RoShamBo GetRoShamBo()
        {
            Console.Write("Rock, Paper, or Scissors? (R/P/S): ");
            ConsoleKey choice = Console.ReadKey().Key;
            Console.WriteLine();

            if (choice == ConsoleKey.R)
            {
                return RoShamBo.Rock;
            }
            else if (choice == ConsoleKey.P)
            {
                return RoShamBo.Paper;
            }
            else if(choice == ConsoleKey.S)
            {
                return RoShamBo.Scissors;
            }
            else
            {
                return GetRoShamBo();
            }
        }

        public IPlayer GetOtherPlayer()
        {
            Console.Write("Would you like to play against The Boulder or The Machine (B/M)? ");
            ConsoleKey choice = Console.ReadKey().Key;
            Console.WriteLine();

            if (choice == ConsoleKey.B)
            {
                return new RockPlayer("The Boulder");
            }
            else if (choice == ConsoleKey.M)
            {
                return new RandomPlayer("The Machine");
            }
            else
            {
                return GetOtherPlayer();
            }
        }
    }
}
