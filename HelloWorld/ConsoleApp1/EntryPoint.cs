using System;

class EntryPoint
{
    static void Main()
    {
        Console.WriteLine("please enter your first number");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter your second number");
        int secondNumber = int.Parse(Console.ReadLine());

        if (firstNumber < secondNumber)
        {
            Console.WriteLine(firstNumber + " is the smallest number");
        }
        else
        {
            Console.WriteLine(secondNumber + " is the smallest number");
        }
    }
}
