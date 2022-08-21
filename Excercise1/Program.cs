// See https://aka.ms/new-console-template for more information

using System;

class Program
{

    static void ValidateNumber()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        if (number >= 1 && number <= 10)
        {
            Console.WriteLine("Valid");
        }
        else
        {
            Console.WriteLine("invalid");
        }

    }

    static void Maximum()
    {
        Console.Write("Enter first number: ");
        int number1 = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int number2 = int.Parse(Console.ReadLine());

        Console.WriteLine(String.Format("Maximum {0}", (number1 > number2) ? number1 : number2));

    }




    static void Main()
    {
        Console.WriteLine("Hello, World!");

        ValidateNumber();
        Maximum();

    }
}



