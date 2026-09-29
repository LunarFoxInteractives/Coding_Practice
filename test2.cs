using System;

namespace BasicSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, C#!");

            int number = 42;
            string name = "Alice";
            bool isReady = true;

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Number: {number}");
            Console.WriteLine($"Ready: {isReady}");

            if (number > 10)
            {
                Console.WriteLine("The number is greater than 10.");
            }
            else
            {
                Console.WriteLine("The number is 10 or less.");
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Loop iteration: {i}");
            }
        }
    }
}
