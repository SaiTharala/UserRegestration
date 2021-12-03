using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationPrograms
{
    class MobileFormat
    {
        public string Mobile = "^[0-9]{2}[ ]{1}[0-9]{10}$";
        public void ValidateMobile(string number)
        {
            Regex regex = new Regex(Mobile);
            bool check = regex.IsMatch(number);
            if (check)
            {
                Console.WriteLine("Valid Mobile Number\n");
            }
            else
            {
                Console.WriteLine("Invalid!!");
            }
        }
    }
}