using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day19_UserRegistration
{
    class CheckingFirstNameSample
    {
        public static string Regex_SampleFirstName = "^[A - Z][a - z]{2,}$";

        public static bool ValidateFirstName(string SampleEmail)
        {
            return Regex.IsMatch(SampleEmail, Regex_SampleFirstName);
        }

    }
}
