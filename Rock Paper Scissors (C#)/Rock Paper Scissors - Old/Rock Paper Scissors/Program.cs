using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            String name;
            String player;
            int playerblood = 3;
            int aiblood = 3;
            String computer;
            String computername = "AI";
            String answer;

            Console.Write("Enter your name:");
            name = Console.ReadLine();
            name = name.ToUpper();


            while (playAgain)
            {
                while (playerblood != 0 && aiblood != 0)
                {
                    player = "";
                    computer = "";
                    answer = "";

                    while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                    {
                        Console.Write("Enter ROCK, PAPER, or SCISSORS: ");
                        player = Console.ReadLine();
                        player = player.ToUpper();
                    }


                    switch (random.Next(1, 4))
                    {
                        case 1:
                            computer = "ROCK";
                            break;
                        case 2:
                            computer = "PAPER";
                            break;
                        case 3:
                            computer = "SCISSORS";
                            break;
                    }

                    Console.WriteLine("Player: " + player);
                    Console.WriteLine("Computer: " + computer);

                    switch (player)
                    {
                        case "ROCK":
                            if (computer == "ROCK")
                            {
                                Console.WriteLine("It's a draw!");

                            }
                            else if (computer == "PAPER")
                            {
                                Console.WriteLine("You lose!");
                                playerblood = playerblood - 1;

                            }
                            else
                            {
                                Console.WriteLine("You win!");
                                aiblood = aiblood - 1;
                            }
                            Console.WriteLine(name + " Blood: " + playerblood);
                            Console.WriteLine("AI Blood: " + aiblood);
                            break;
                        case "PAPER":
                            if (computer == "ROCK")
                            {
                                Console.WriteLine("You win!");
                                aiblood = aiblood - 1;
                            }
                            else if (computer == "PAPER")
                            {
                                Console.WriteLine("It's a draw!");
                            }
                            else
                            {
                                Console.WriteLine("You lose!");
                                playerblood = playerblood - 1;
                            }
                            Console.WriteLine(name + " Blood: " + playerblood);
                            Console.WriteLine("AI Blood: " + aiblood);
                            break;
                        case "SCISSORS":
                            if (computer == "ROCK")
                            {
                                Console.WriteLine("You lose!");
                                playerblood = playerblood - 1;
                            }
                            else if (computer == "PAPER")
                            {
                                Console.WriteLine("You win!");
                                aiblood = aiblood - 1;
                            }
                            else
                            {
                                Console.WriteLine("It's a draw!");
                            }
                            Console.WriteLine(name + " Blood: " + playerblood);
                            Console.WriteLine("AI Blood: " + aiblood);
                            break;
                    }



                }
                Console.Write("Would you like to play again (Y/N): ");
                answer = Console.ReadLine();
                answer = answer.ToUpper();

                if (answer == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("Thanks for playing!");

            Console.ReadKey();
        }
    }
}
