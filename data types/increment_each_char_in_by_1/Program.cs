using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();

        string result = "";

        foreach (char ch in str)
        {
            char c = (char)(ch + 1);

            if (char.IsLetter(c))
            {
                if (char.IsUpper(c))
                    c = char.ToLower(c);
                else
                    c = char.ToUpper(c);
            }

            result += c;
        }

        Console.WriteLine("New String: " + result);
    }
}
