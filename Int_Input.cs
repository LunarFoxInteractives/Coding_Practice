using System;

namespace Int_Input;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("========================================");
        Console.WriteLine("Welcome Back!, This is my 2nd C# Program");
        Console.WriteLine("========================================");

        Console.WriteLine();

        Console.WriteLine("===========================================================");
        Console.WriteLine("Here, The Program is using 'TryParse' to take Integer Input ");
        Console.WriteLine("===========================================================");

        Console.WriteLine();

        Console.WriteLine("==============");
        Console.WriteLine("Enter a Number");
        Console.WriteLine("==============");
         
        string input = Console.ReadLine();

       /*The Line 30 will check if the input is a valid Integer or not
       If not then it will print an Error Message */

        if (int.TryParse(input, out int number))
        {
            Console.WriteLine("You Entered: " + number);
        }

        else
        {
            Console.WriteLine("Invalid Input. Please Enter a Valid Integer.");
        }

    }
}

//There are two ways to take Integer Input in C#
// This is the First method which is using TryParse Method