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
                Console.WriteLine("Enter your Choice Number to Validate Program\n 1.First Name\n 2.Exit\n");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        ValidateFN FirstName = new ValidateFN();
                        Console.WriteLine("Enter the First Name to Check Validation:");
                        string input = Console.ReadLine();
                        FirstName.ValidateFirstName(input);
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }
        }
    }
}
