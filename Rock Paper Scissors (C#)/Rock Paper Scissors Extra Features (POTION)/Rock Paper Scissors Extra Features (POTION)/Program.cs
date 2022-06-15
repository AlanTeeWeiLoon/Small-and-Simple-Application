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
            String name;
            String p_play;
            String c_play;
            int p_point = 3;
            int c_point = 3;
            bool potion = true;

            Console.WriteLine("---------------- Game Start ----------------------- ");
            Console.WriteLine("Enter Your Name: ");
            name = Console.ReadLine();

            while (p_point != 0 && c_point != 0)
            {
                p_play = "";
                c_play = "";
                while (p_play != "ROCK" && p_play != "PAPER" && p_play != "SCISSORS" && p_play != "POTION")
                {
                    if (potion)
                    {
                        Console.WriteLine("Enter ROCK, PAPER, or SCISSORS: (You have 1 POTION can use) ");
                        p_play = Console.ReadLine();
                        p_play = p_play.ToUpper();
                    }
                    else
                    {
                        Console.WriteLine("Enter ROCK, PAPER, or SCISSORS: ");
                        p_play = Console.ReadLine();
                        p_play = p_play.ToUpper();
                    }

                }

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

                switch (p_play)
                {
                    case "ROCK":
                        if (c_play == "ROCK")
                        {
                            Console.WriteLine("Draw");
                        }
                        else if (c_play == "PAPER")
                        {
                            Console.WriteLine("Computer Win! You Lose!");
                            p_point = p_point - 1;
                        }
                        else
                        {
                            Console.WriteLine(name + " Win!");
                            c_point = c_point - 1;
                        }
                        Console.WriteLine(name + " Health : " + p_point);
                        Console.WriteLine("Computer Health : " + c_point + "\n");
                        break;

                    case "PAPER":
                        if (c_play == "ROCK")
                        {
                            Console.WriteLine(name + " Win!");
                            c_point = c_point - 1;

                        }
                        else if (c_play == "PAPER")
                        {
                            Console.WriteLine("Draw");
                        }
                        else
                        {
                            Console.WriteLine("Computer Win! You Lose!");
                            p_point = p_point - 1;

                        }
                        Console.WriteLine(name + " Health : " + p_point);
                        Console.WriteLine("Computer Health : " + c_point + "\n");
                        break;

                    case "SCISSORS":
                        if (c_play == "ROCK")
                        {
                            Console.WriteLine("Computer Win! You Lose!");
                            p_point = p_point - 1;
                        }
                        else if (c_play == "PAPER")
                        {
                            Console.WriteLine(name + " Win!");
                            c_point = c_point - 1;
                        }
                        else
                        {
                            Console.WriteLine("Draw");
                        }
                        Console.WriteLine(name + " Health : " + p_point);
                        Console.WriteLine("Computer Health : " + c_point + "\n");
                        break;
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


                        Console.WriteLine(name + " Health : " + p_point);
                        Console.WriteLine("Computer Health : " + c_point + "\n");
                        break;
                }
            }
            Console.ReadKey();
        }

    }
}