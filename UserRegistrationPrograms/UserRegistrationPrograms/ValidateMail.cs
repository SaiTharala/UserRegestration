using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationPrograms
{
    class ValidateMail
    {
        public string Email = "^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$";
        public void ValidateEmail(string mail)
        {
            Regex regex = new Regex(Email);
            bool check = regex.IsMatch(mail);
            if (check)
            {
                Console.WriteLine("Valid Mail Address");
            }
            else
            {
                Console.WriteLine("Invalid!!");
            }
        }
    }
}