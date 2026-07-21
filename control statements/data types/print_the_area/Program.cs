using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter side of square: ");
        double side = Convert.ToDouble(Console.ReadLine());

        double area = side * side;

        Console.WriteLine("Area of Square = " + area);
    }
}
