using System;

class Program
{
    static void Main()
    {
        int firstNumber = 20;
        int secondNumber = 7;

        int addition = firstNumber + secondNumber;
        int substraction = firstNumber - secondNumber;
        int multiplication = firstNumber * secondNumber;
        double division = (double)firstNumber / (double)secondNumber;

        Console.WriteLine(addition);
        Console.WriteLine(substraction);
        Console.WriteLine(multiplication);
        Console.WriteLine(division);

        firstNumber++;
        Console.WriteLine(firstNumber);

        Console.WriteLine(551 % 2);
    }
}
