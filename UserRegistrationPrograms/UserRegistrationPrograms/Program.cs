using System;

namespace UserRegistrationPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To User Registration\n");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter your Choice Number to Validate Program\n 1.Last Name\n 2.Exit\n");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        ValidateLN LastName = new ValidateLN();
                        Console.WriteLine("Enter the Last Name to Check Validation:");
                        string Last = Console.ReadLine();
                        LastName.ValidateLastName(Last);
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }
        }
    }
}