using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();

        int digits = 0, alphabets = 0;

        foreach (char ch in str)
        {
            if (char.IsDigit(ch))
                digits++;
            else if (char.IsLetter(ch))
                alphabets++;
        }

        Console.WriteLine("Digits = " + digits);
        Console.WriteLine("Alphabets = " + alphabets);
    }
}
