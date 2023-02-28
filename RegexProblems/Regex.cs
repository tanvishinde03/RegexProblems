using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProblems
{
    public class RegexProgram
    {

        public void ValidateFirstName(string name)
        {
            //Tanvi
            string firstName = "^[A-Z][a-z]{3,}?";
            if (Regex.IsMatch(name, firstName))
            {

                Console.WriteLine("first Name is matching with Regex ");
            }
            else
            {
                Console.WriteLine("first Name is not matching with Regex");
            }
            
        }
        public void ValidateLastName(string name)
        {
            //Shinde
            string lastName = "^[A-Z][a-z]{3,}?";
            if (Regex.IsMatch(name, lastName))
            {
                Console.WriteLine("Last name is matching with Regex");
            }
            else
            {
                Console.WriteLine("Last Name is not matching with Regex");
            }
        }
        public void ValidateEmail(string email)
        {
            //abc.xyz@bridgelabz.co.in
            string emailID = "^[a-zA-Z]+[.+_-]{0,1}[a-z]+[@][a-zA-Z]+[.][a-z]{2,3}([.][a-z]{2}){0,1}$";

            if (Regex.IsMatch(email, emailID))
            {
                Console.WriteLine("Email is matching with Regex");
            }
            else
            {
                Console.WriteLine("Email is not matching Regex ");
            }
            Console.ReadLine();
        }
    }
}

