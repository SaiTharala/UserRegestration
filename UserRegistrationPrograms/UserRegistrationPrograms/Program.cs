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
                Console.WriteLine("Enter your Choice Number to Validate Program\n 1.Password Rule 2\n 2.Exit\n");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {

                    case 1:
                        Password2 ruletwo = new Password2();
                        Console.WriteLine("Enter the Password for Validation:");
                        string passwordtwo = Console.ReadLine();
                        ruletwo.ValidateRuleTwo(passwordtwo);
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }
        }
    }
}