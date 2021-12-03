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
                Console.WriteLine("Enter your Choice Number to Validate Program\n 1.Password\n 2.Exit\n");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    
                    case 1:
                        Password1 rule = new Password1();
                        Console.WriteLine("Enter the Password for Validation:");
                        string password = Console.ReadLine();
                        rule.ValidateRuleOne(password);
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }
        }
    }
}