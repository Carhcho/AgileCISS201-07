using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Cesar Roncancio
//CISS201
//Agile Development
//9/27/2020
namespace dropbox07
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;
            while(playAgain)
            {
                string userShape = UserShape();
                string computerShape = ComputerShape();
                string winner = Winner(userShape, computerShape);
                Console.WriteLine("User shape: {0}\nComputer shape: {1}\n{2} won", userShape, computerShape, winner);
                Console.WriteLine("Play again? y/n");
                string choice = Console.ReadLine().ToUpper();
                if (choice == "Y" || choice == "YES")
                    playAgain = true;
                else
                {
                    Console.WriteLine("Thanks for playing.");
                    playAgain = false;
                }
            }
            Console.ReadKey();
        }
        private static string Winner(string userShape, string computerShape)
        {
            string winner = "Nobody";
            if (userShape == "ROCK" && computerShape == "PAPER" || userShape == "PAPER" && computerShape == "SCISSORS" || userShape == "SCISSORS" && computerShape == "ROCK")
                winner = "Computer";
            else if (userShape == "ROCK" && computerShape == "SCISSORS" || userShape == "PAPER" && computerShape == "ROCK" || userShape == "SCISSORS" && computerShape == "PAPER")
                winner = "Player";
            return winner;
        }
        private static string ComputerShape()
        {
            string str = "PAPER";
            Random random = new Random();
            int randomNumber = random.Next(1, 4);
            switch(randomNumber)
            {
                case 1:
                    str = "ROCK";
                    break;
                case 2:
                    str = "PAPER";
                    break;
                case 3:
                    str = "SCISSORS";
                    break;
            }
            return str;
        }
        private static string UserShape()
        {
            string str = "ROCK";
            bool isCorrectSpelling = false;
            while(!isCorrectSpelling)
            {
                Console.WriteLine("Enter Rock, Paper, or Scissors:");
                str = Console.ReadLine().ToUpper();
                if (str == "ROCK" || str == "PAPER" || str == "SCISSORS")
                    isCorrectSpelling = true;
            }
            return str;
        }
    }
}
