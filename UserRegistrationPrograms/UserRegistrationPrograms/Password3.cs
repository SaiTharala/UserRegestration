using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationPrograms
{
    class Password3
    {
        public string PasswordRule3 = "^(?=.*[0-9])(?=.*[A-Z])[0-9a-zA-Z]{8,}$";     
        public void ValidateRuleThree(string passwordthree)
        {
            Regex regex = new Regex(PasswordRule3);
            bool check = regex.IsMatch(passwordthree);
            if (check)
            {
                Console.WriteLine("Valid Password\n");
            }
            else
            {
                Console.WriteLine("Invalid!!");
            }
        }
    }
}