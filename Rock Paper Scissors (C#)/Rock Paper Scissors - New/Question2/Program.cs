using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            String name;                        //User Name
            String p_play;                      //Player play
            String c_play;                      //Computer play
            int p_point = 3;                    //Player Point(Health)
            int c_point = 3;                    //Computer Point(Health)
            bool potion = true;                 //Potion Status - Only 1 (Is the player used?)
            int result = -1;                    //Result of the round (0 = draw; 1 = Player Lose; 2 = Player Win)

            // Game Start
            Console.WriteLine("---------------- Game Start ----------------------- ");

            // Prompt Player to enter the name
            Console.WriteLine("Enter Your Name: ");
            name = Console.ReadLine();

            // Loop if both computer and player still got point(Health)
            while (p_point != 0 && c_point != 0)
            {
                // Reset the Player's and Computer's play ever turn
                p_play = "";
                c_play = "";
                result = -1;

                while (p_play != "ROCK" && p_play != "PAPER" && p_play != "SCISSORS" && p_play != "POTION")
                {        
                    //While potion haven't use
                    if (potion)
                    {
                        //Prompt Player to input the play
                        Console.WriteLine("Enter ROCK, PAPER, or SCISSORS: (You have 1 POTION can use) ");
                        p_play = Console.ReadLine();
                        p_play = p_play.ToUpper();

                        //Validate the input
                        if (p_play != "ROCK" && p_play != "PAPER" && p_play != "SCISSORS" && p_play != "POTION")
                        {
                            Console.WriteLine("\nInvalid Input! Please enter valid input.");
                            Console.WriteLine("Enter ROCK, PAPER, or SCISSORS: (You have 1 POTION can use) ");
                            p_play = Console.ReadLine();
                            p_play = p_play.ToUpper();
                        }
                    }
                    //While potion used
                    else
                    {
                        Console.WriteLine("Enter ROCK, PAPER, or SCISSORS: ");
                        p_play = Console.ReadLine();
                        p_play = p_play.ToUpper();

                        if (p_play != "ROCK" && p_play != "PAPER" && p_play != "SCISSORS")
                        {
                            Console.WriteLine("\nInvalid Input! Please enter valid input.");
                            Console.WriteLine("Enter ROCK, PAPER, or SCISSORS: ");
                            p_play = Console.ReadLine();
                            p_play = p_play.ToUpper();
                        }
                    }
                }

                // Switch case for ramdon generate the computer play
                switch (random.Next(1, 4))
                {
                    case 1:
                        c_play = "ROCK";
                        break;
                    case 2:
                        c_play = "PAPER";
                        break;
                    case 3:
                        c_play = "SCISSORS";
                        break;
                }
                Console.WriteLine(name + ": " + p_play);
                Console.WriteLine("Computer: " + c_play);

                // Switch case for validate player or computer Win 
                switch (p_play)
                {
                    case "ROCK":
                        result = c_play == "ROCK" ? 0 : (c_play == "PAPER" ? 1 : 2);
                        break;

                    case "PAPER":
                        result = c_play == "PAPER" ? 0 : (c_play == "SCISSORS" ? 1 : 2);
                        break;

                    case "SCISSORS":
                        result = c_play == "SCISSORS" ? 0 : (c_play == "ROCK" ? 1 : 2);
                        break;

                    // POTION case: When player used, player point will increase by 1
                    case "POTION":
                        if (potion)
                        {
                            Console.WriteLine("You used the POTION! Health + 1");
                            p_point = p_point + 1;
                            potion = false;
                        }
                        else
                        {
                            Console.WriteLine("You don't have any more POTION can use");
                        }
                        break;
                }

                // Display result
                if (result == 0)
                {
                    Console.WriteLine("Draw");
                }
                else if (result == 1)
                {
                    Console.WriteLine("Computer Win! You Lose!");
                    p_point = p_point - 1;
                }
                else if (result == 2)
                {
                    Console.WriteLine(name + " Win!");
                    c_point = c_point - 1;
                }
                else
                {
                    Console.WriteLine("Something Went Wrong! Please Try Again!");
                }

                // Display the remaining point(Health) of player and computer
                Console.WriteLine(name + " Health : " + p_point);
                Console.WriteLine("Computer Health : " + c_point + "\n");
            }
            Console.ReadKey();
        }

    }
}
