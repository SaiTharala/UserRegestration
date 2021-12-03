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
                Console.WriteLine("Enter your Choice Number to Validate Program\n 1.PasswordRule3\n 2.Exit\n");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    
                    case 1:
                        Password3 rulethree = new Password3();
                        Console.WriteLine("Enter the Password for Validation:");
                        string passwordthree = Console.ReadLine();
                        rulethree.ValidateRuleThree(passwordthree);
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }
        }
    }
}