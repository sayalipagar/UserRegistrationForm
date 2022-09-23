using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationForm
{
    internal class ValidationForm
    {
        //UC1
        public const string FIRST_NAME_REGEX = "^[A-Z]{1}[a-zA-Z]{2}$";
        //UC2......
        public const string LAST_NAME_REGEX = "^[A-Z]{1}[a-zA-Z]{2}$";
        //UC3
        public const string EMAILID_REGEX = "^[a-z]+[.][a-z]+[@][a-z]+[.][a-z]+[.][a-z]{2,3}$";
        public void FirstName(string firstname)
        {
            Regex regex = new Regex(FIRST_NAME_REGEX);
            bool result = regex.IsMatch(firstname);
            Console.WriteLine(result);
        }
        public void LastName(string lastname)
        {
            Regex regex = new Regex(LAST_NAME_REGEX);
            bool result = regex.IsMatch(lastname);
            Console.WriteLine(result);
        }
        public void EmailID(string emailid)
        {
            Regex regex = new Regex(EMAILID_REGEX);
            bool result = regex.IsMatch(emailid);
            Console.WriteLine(result);
        }
    }
}
