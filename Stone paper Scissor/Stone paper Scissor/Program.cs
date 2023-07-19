using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stone_paper_Scissor
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int PlayerScore = 0;
            int CPUScore = 0;

            Console.WriteLine("Lets Play Stone Paper Scissor");

            while (PlayerScore != 3 && CPUScore != 3)
            {
                Console.WriteLine(" Player  score - " + PlayerScore + " CPU score - " + CPUScore);
                Console.WriteLine("Enter 's' for stone, 'p' for Paper, and 'c' for scissor ");
                String Playerchoice = Console.ReadLine();

                int CPUchoice = random.Next(0, 3);

                if (CPUchoice == 0)
                {
                    Console.WriteLine("CPU choice is Stone .");
                    switch (Playerchoice)
                    {
                        case "s":
                            Console.WriteLine("DRAW!!");
                            break;

                        case "p":
                            Console.WriteLine("WON!!");
                            PlayerScore++;
                            break;

                        case "c":
                            Console.WriteLine("LOSE!!");
                            CPUScore++;
                            break;

                        default:
                            Console.WriteLine("Galt!");
                            break;
                    }
                }
                else if (CPUchoice == 1)
                {
                    Console.WriteLine("CPU choice is Paper .");

                    switch (Playerchoice)
                    {
                        case "s":
                            Console.WriteLine("LOSE!!");
                            CPUScore++;
                            break;

                        case "p":
                            Console.WriteLine("DRAW!!");
                            break;

                        case "c":
                            Console.WriteLine("WON!!");
                            PlayerScore++;
                            break;

                        default:
                            Console.WriteLine("Galt!");
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("CPU choice is Scissor .");
                    switch (Playerchoice)
                    {
                        case "s":
                            Console.WriteLine("WON!!");
                            PlayerScore++;
                            break;

                        case "p":
                            Console.WriteLine("LOSE!!");
                            CPUScore++;
                            break;

                        case "c":
                            Console.WriteLine("DRAW!!");
                            break;

                        default:
                            Console.WriteLine("Galt!");
                            break;
                    }
                }

            }
            if (PlayerScore == 3)
            {
                Console.WriteLine("You Win!");
            }
            else
            {
                Console.WriteLine("you Lose!");
            }
            
        }
    }
}