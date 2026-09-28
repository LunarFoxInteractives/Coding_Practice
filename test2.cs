using System;

class Program
{
	static void Main()
	{
		Console.Write("Enter your name: ");
		string name = Console.ReadLine();

		Console.Write("Enter your age: ");
		string age = Console.ReadLine();

		Console.Write("Enter your school: ");
		string school = Console.ReadLine();

		Console.WriteLine($"Name: {name}");
		Console.WriteLine($"Age: {age}");
		Console.WriteLine($"School: {school}");
	}
}
