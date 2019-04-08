
using System;

class EntryPoint
 {
    static void Main()
    {
        Console.WriteLine("Hello World");
        Console.WriteLine("");
        Console.WriteLine("what is your name ?");
        string firstName = Console.ReadLine();
        Console.WriteLine(firstName);
        Console.WriteLine("what is your age ?");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine(age);


    }
 }

