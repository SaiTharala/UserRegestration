using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationPrograms
{
    class ValidateFN
    {
        public string First_Name = "^[A-Z]{1}[A-Za-z]{3,}$";
        public void ValidateFirstName(string name)
        {
            Regex regex = new Regex(First_Name);
            bool check = regex.IsMatch(name);
            if (check)
            {
                Console.WriteLine("Valid Name");
            }
            else
            {
                Console.WriteLine("Invalid!!");
            }


        }
    }
}