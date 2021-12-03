using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationPrograms
{
    class Password2
    {
        public string PasswordRule2 = "^(?=.*[A-Z])[0-9a-zA-Z]{8,}";
        public void ValidateRuleTwo(string passwordtwo)
        {
            Regex regex = new Regex(PasswordRule2);
            bool check = regex.IsMatch(passwordtwo);
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