using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationPrograms
{
    class ValidateLN
    {
        public string Last_Name = "^[A-Z]{1}[A-Za-z]{3,}$";
        public void ValidateLastName(string name)
        {
            Regex regex = new Regex(Last_Name);
            bool check = regex.IsMatch(name);
            if (check)
            {
                Console.WriteLine("Valid Last Name");
            }
            else
            {
                Console.WriteLine("Invalid!!");
            }
        }
    }
}