using System;

class Program
{
    static void Main()
    {
        string user = "admin";
        string pass = "1234";

        for (int i = 1; i <= 3; i++)
        {
            Console.Write("Enter Username: ");
            string u = Console.ReadLine();

            Console.Write("Enter Password: ");
            string p = Console.ReadLine();

            if (u == user && p == pass)
            {
                Console.WriteLine("Login Successful");
                return;
            }
            else
            {
                Console.WriteLine("Wrong Username or Password");
            }
        }

        Console.WriteLine("User Rejected");
    }
}
