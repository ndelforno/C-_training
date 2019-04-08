
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

        int age = 0;

        while (true)
        {
            Console.WriteLine("how old are you ?");
            age = int.Parse(Console.ReadLine());

            if (age <= 10 && age >= 1)
            {
                break;
            }

        }
        
        
        Console.WriteLine(age);


    }
 }

