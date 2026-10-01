using System;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========================================================================");
            Console.WriteLine("Welcome Back!!, This is My first Project of all I've Learnt");
            Console.WriteLine("===========================================================================");

            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("Please Enter Your Username : ");
            Console.WriteLine("=========================================");

            string user = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("===========================================================");
            Console.WriteLine($"Hii {user}, Welcone to my first Project :)");
            Console.WriteLine("===========================================================");

            Console.WriteLine();

            Console.WriteLine("===============================================");
            Console.WriteLine($"Do you want to proceed {user}?");
            Console.WriteLine("===============================================");

            Console.WriteLine();

            string input = Console.ReadLine();

            Console.WriteLine();

            if (input.Equals("yes", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("======================================================");
                Console.WriteLine("Which Class Do You Want To Choose");
                Console.WriteLine("======================================================");
                Console.WriteLine("1. Archer");
                Console.WriteLine("2. Magician");
                Console.WriteLine("3. Telekinesis");
                Console.WriteLine("4. Teleport");
                Console.WriteLine("======================================================");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.WriteLine("=================================");
                    Console.WriteLine("You Have Choosed Archer");
                    Console.WriteLine("=================================");

                    Console.WriteLine();

                    Console.WriteLine("================================================");
                    Console.WriteLine("Are You Ready to check Your Player Stats?");
                    Console.WriteLine("================================================");

                    if (input.Equals("yes", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("==============================================");
                        Console.WriteLine($"Player : {user} [Archer]");
                        Console.WriteLine("HP : 150");
                        Console.WriteLine("Energy : 100");
                        Console.WriteLine("Special Power : BullsEye [100% Accuracy]");
                        Console.WriteLine("==============================================");
                    }
                    else
                    {
                        Console.WriteLine("==================");
                        Console.WriteLine("Take Your Time");
                        Console.WriteLine("==================");
                    }
                }

                else if (choice == "2")
                {
                    Console.WriteLine("================================");
                    Console.WriteLine("You Have Choosed Magician");
                    Console.WriteLine("================================");

                    Console.WriteLine();

                    Console.WriteLine("================================================");
                    Console.WriteLine("Are You Ready to check Your Player Stats?");
                    Console.WriteLine("================================================");

                    if (input.Equals("yes", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("==============================================");
                        Console.WriteLine($"Player : {user} [Magician]");
                        Console.WriteLine("HP : 150");
                        Console.WriteLine("Energy : 100");
                        Console.WriteLine("Special Power : True form Unleash");
                        Console.WriteLine("==============================================");
                    }
                    else
                    {
                        Console.WriteLine("==================");
                        Console.WriteLine("Take Your Time");
                        Console.WriteLine("==================");
                    }
                }

                else if (choice == "3")
                {
                    Console.WriteLine("================================");
                    Console.WriteLine("You Have Choosed Telekinesis");
                    Console.WriteLine("================================");

                    Console.WriteLine();

                    Console.WriteLine("================================================");
                    Console.WriteLine("Are You Ready to check Your Player Stats?");
                    Console.WriteLine("================================================");

                    if (input.Equals("yes", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("==============================================");
                        Console.WriteLine($"Player : {user} [Telekinesis]");
                        Console.WriteLine("HP : 150");
                        Console.WriteLine("Energy : 100");
                        Console.WriteLine("Special Power : Aerokinesis [Can Control Air]");
                        Console.WriteLine("==============================================");
                    }
                    else
                    {
                        Console.WriteLine("==================");
                        Console.WriteLine("Take Your Time");
                        Console.WriteLine("==================");
                    }
                }

                else if (choice == "4")
                {
                    Console.WriteLine("================================");
                    Console.WriteLine("You Have Choosed Teleportation");
                    Console.WriteLine("================================");

                    Console.WriteLine();

                    Console.WriteLine("================================================");
                    Console.WriteLine("Are You Ready to check Your Player Stats?");
                    Console.WriteLine("================================================");

                    if (input.Equals("yes", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("==============================================");
                        Console.WriteLine($"Player : {user} [Teleportation]");
                        Console.WriteLine("HP : 150");
                        Console.WriteLine("Energy : 100");
                        Console.WriteLine("Special Power : Invisible [Temporary]");
                        Console.WriteLine("==============================================");
                    }
                    else
                    {
                        Console.WriteLine("==================");
                        Console.WriteLine("Take Your Time");
                        Console.WriteLine("==================");
                    }
                }

                else
                {
                    Console.WriteLine("================================");
                    Console.WriteLine("Invalid Option");
                    Console.WriteLine("================================");
                }
            }

            else
            {
                Console.WriteLine("================================");
                Console.WriteLine("We Will Wait till you proceed");
                Console.WriteLine("================================");
            }
        
        }
    }
}

