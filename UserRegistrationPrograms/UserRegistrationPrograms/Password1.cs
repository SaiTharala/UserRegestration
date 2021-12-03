using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationPrograms
{
    class Password1
    {
        public string PasswordRule1 = @"[a-z,A-Z,0-9]{8,}$";     
        public void ValidateRuleOne(string password)
        {
            Regex regex = new Regex(PasswordRule1);
            bool check = regex.IsMatch(password);
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