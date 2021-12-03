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
                Console.WriteLine("Enter your Choice Number to Validate Program\n 1.Mobile Number\n 2.Exit\n");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                   case 1:
                        MobileFormat num = new MobileFormat();
                        Console.WriteLine("Enter the Mobile Number for Validation:");
                        string number = Console.ReadLine();
                        num.ValidateMobile(number);
                        break;
                   case 2:
                        flag = false;
                        break;
                }
            }
        }
    }
}