using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 % 10 == num2)
            Console.WriteLine("Unit Place");
        else if ((num1 / 10) % 10 == num2)
            Console.WriteLine("Tens Place");
        else if ((num1 / 100) % 10 == num2)
            Console.WriteLine("Hundreds Place");
        else if ((num1 / 1000) % 10 == num2)
            Console.WriteLine("Thousands Place");
        else
            Console.WriteLine("Digit Not Found");
    }
}
