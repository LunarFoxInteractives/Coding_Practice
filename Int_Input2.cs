using System;

namespace Intro;

class Program
{
    static void Main(string [] args)
    {
        Console.WriteLine("===========================================");
        Console.WriteLine("Welcome Back!!. This is my third C# Program");
        Console.WriteLine("===========================================");

        Console.WriteLine();

        Console.WriteLine("================================================================");
        Console.WriteLine("Today, We will check If you are eligible to vote in India or not");
        Console.WriteLine("================================================================");
        
        Console.WriteLine();

        Console.WriteLine("=================");
        Console.WriteLine("What is Your Age?");
        Console.WriteLine("=================");
        
        Console.WriteLine();

        /* The Line 29 Will take input from the user and
        store it in the variable 'age' of type int. */

        /* The Line 29 will check if the input is a valid Integer or not
        If not then it will Crash the Program */

        int age = Convert.ToInt32(Console.ReadLine());

        if (age >= 18)

        {
        Console.WriteLine($"You are {age} Years Old. You are Eligible to Vote in India.");
        }

        else
        {
            Console.WriteLine("You are not eligible to vote in India.");
        }
}

}