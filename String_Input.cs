using System;

namespace Intro;

class Program
{  
    static void Main(string [] arg)
    {
        Console.WriteLine("=================================");
        Console.WriteLine("Hii!! This is My First C# Program");
        Console.WriteLine("=================================");

        Console.WriteLine();

        Console.WriteLine("==================================================");
        Console.WriteLine("This Program Will Take a String Input and Print it");
        Console.WriteLine("==================================================");

        Console.WriteLine();

        Console.WriteLine("=====================");
        Console.WriteLine("Enter Your Name below");
        Console.WriteLine("=====================");

        Console.WriteLine();

        string name = Console.ReadLine();

        Console.WriteLine();

        Console.WriteLine("Hii " + name);

    }
}
