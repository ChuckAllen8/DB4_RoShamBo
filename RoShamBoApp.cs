using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace DB4_RoShamBo
{

    class RoShamBoApp
    {
        public void Run()
        {
            Validator validator = new Validator();
            string input = "";
            
            Console.WriteLine("Welcome to Rock Paper Scissors!\n");

            while (input == "")
            {
                Console.Write("Enter your name: ");
                input = Console.ReadLine();
            }

            IPlayer user = new HumanPlayer(input);
            IPlayer computer = validator.GetOtherPlayer();

            do
            {
                Console.WriteLine();

                user.GenerateRoShamBo();
                computer.GenerateRoShamBo();

                DisplayOutcome(user, computer, DetermineWinner(user, computer));
                DisplayScore(user, computer);

            } while (validator.GetYN() == "Y");
        }

        private void DisplayScore(IPlayer user, IPlayer computer)
        {
            Console.WriteLine();
            Console.WriteLine($"{user.Name}: {user.Score,2}\t{computer.Name}: {computer.Score,2}");
            Console.WriteLine();
        }

        private void DisplayOutcome(IPlayer user, IPlayer computer, IPlayer winner)
        {
            Console.WriteLine();
            Console.WriteLine($"{user.Name,-20}{user.Choice}");
            Console.WriteLine($"{computer.Name,-20}{computer.Choice}");
            if (winner == null)
            {
                Console.WriteLine($"Draw!");
            }
            else
            {
                Console.WriteLine($"{winner.Name} wins!");
            }
        }

        private IPlayer DetermineWinner(IPlayer user, IPlayer computer)
        {
            if(user.Choice == computer.Choice)
            {
                return null;
            }
            else if (user.Choice == computer.Choice + 1 || user.Choice == computer.Choice - 2)
            {
                user.Score += 1;
                return user;
            }
            else
            {
                computer.Score += 1;
                return computer;
            }
        }
    }
}
