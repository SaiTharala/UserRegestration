using System;
using System.Text.RegularExpressions;

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
                Console.WriteLine("Enter your Choice Number to Validate Program\n 1.Email\n 2.Exit\n");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        ValidateMail mail = new ValidateMail();
                        Console.WriteLine("Enter the Email Address for Validation:");
                        string Email = Console.ReadLine();
                        mail.ValidateEmail(Email);
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }
        }
    }
}