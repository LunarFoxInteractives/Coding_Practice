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

            Console.WriteLine();

             string name = Console.ReadLine();

            Console.WriteLine();

             /*The Line 18 will take input from the user and
            store it in the variable 'name' of type string.*/
            
            Console.WriteLine("====================");
            Console.WriteLine("Hello, " + name + "!");
            Console.WriteLine("====================");

            Console.WriteLine();

            Console.WriteLine("===========================");
            Console.WriteLine("This is my Fourth C# Program");
            Console.WriteLine("===========================");

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