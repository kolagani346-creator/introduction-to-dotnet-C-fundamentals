using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();

        // 1. Reverse
        char[] arr = str.ToCharArray();
        Array.Reverse(arr);
        Console.WriteLine("Reverse: " + new string(arr));

        // 2. Extract from 2nd position
        if (str.Length > 1)
            Console.WriteLine("Substring: " + str.Substring(1));

        // 3. Replace character
        Console.Write("Enter character to replace: ");
        char ch = Convert.ToChar(Console.ReadLine());

        string replaced = str.Replace(ch, '$');
        Console.WriteLine("After Replace: " + replaced);

        // 4. Copy and modify
        string str2 = str;
        str2 = str2 + " CSharp";

        Console.WriteLine("Original String: " + str);
        Console.WriteLine("Copied & Modified String: " + str2);
    }
}