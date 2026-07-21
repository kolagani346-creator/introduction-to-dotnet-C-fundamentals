using System;

class Program
{
    static void Main()
    {
        int num1, num2, temp;

        Console.Write("Enter num1: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter num2: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Pre-Increment: " + (++num1));

        Console.WriteLine("Post-Increment: " + (num1++));

        temp = num1;
        num1 = num2;
        num2 = temp;

        Console.WriteLine("After Swapping:");
        Console.WriteLine("num1 = " + num1);
        Console.WriteLine("num2 = " + num2);
    }
}
