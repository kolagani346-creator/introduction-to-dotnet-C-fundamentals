using System;

class Program
{
    static void Main()
    {
        int[] a = new int[10];
        int sum = 0;

        Console.WriteLine("Enter 10 numbers:");

        for (int i = 0; i < 10; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
            sum += a[i];
        }

        int min = a[0], max = a[0];

        for (int i = 0; i < 10; i++)
        {
            if (a[i] < min)
                min = a[i];
            if (a[i] > max)
                max = a[i];
        }

        // Descending Order
        for (int i = 0; i < 9; i++)
        {
            for (int j = i + 1; j < 10; j++)
            {
                if (a[i] < a[j])
                {
                    int temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                }
            }
        }

        Console.Write("Descending Order: ");
        for (int i = 0; i < 10; i++)
            Console.Write(a[i] + " ");

        Console.WriteLine("\nMin = " + min);
        Console.WriteLine("Max = " + max);
        Console.WriteLine("Sum = " + sum);
    }
}