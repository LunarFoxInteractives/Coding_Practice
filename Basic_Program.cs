using System;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Hii");

            Console.WriteLine();

            Console.WriteLine("===================");
            Console.WriteLine("What is Your Name?");
            Console.WriteLine("===================");

             string name = Console.ReadLine();

             /*The Line 16 will take input from the user and
            store it in the variable 'name' of type string.*/
            
            Console.WriteLine("Hello, " + name + "!");
            Console.WriteLine("This is my First C# Program");
            Console.WriteLine();

            Console.WriteLine("=================================");
            Console.WriteLine("What Would You Rate it Out of 10?");
            Console.WriteLine("=================================");

            int Rating = Convert.ToInt32(Console.ReadLine());
            if (Rating <= 5)
            {
                Console.WriteLine($"You Rated it {Rating} out of 10. We will try to improve it.");


            }

            else
            {
                Console.WriteLine($"You Rated it {Rating} out of 10. I Loved Your Feedback :)");
            }

        }
    }
}