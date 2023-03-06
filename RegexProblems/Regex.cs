using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static RegexProblems.UserRegistratinException;
namespace RegexProblems
{
    public class RegexProgram
    {
        string message;
        public RegexProgram(string message)
        {
            this.message = message;
        }

        public string ValidateFirstName(string name)
        {
            string firstName = "^[A-Z][a-z]{3,}?";
            try
            {  
                    if (Regex.IsMatch(name, firstName))
                    {

                        Console.WriteLine("first Name is matching with Regex ");
                    }
                    else
                    {
                        Console.WriteLine("first Name is not matching with Regex");
                    }
                    return name;
                }
            catch (NullReferenceException)
            {
                throw new UserRegistratinException(ExceptionType.NULL_FIRSTNAME, "Please do not Enter the Null Input");
            }
                  
            }


        public string ValidateLastName(string name)
        {
            //Shinde
            string lastName = "^[A-Z][a-z]{3,}?";
            try
            {
                if (Regex.IsMatch(name, lastName))
                {
                    Console.WriteLine("Last name is matching with Regex");
                }
                else
                {
                    Console.WriteLine("Last Name is not matching with Regex");
                }
                return name;
            }
            catch (NullReferenceException)
            {
                throw new UserRegistratinException(ExceptionType.NULL_LASTNAME, "Please do not Enter the Null Input");
            }
        }

        public string ValidateEmail(string email)
        {
            
            string emailID = "^[a-zA-Z]+[.+_-]{0,1}[a-z]+[@][a-zA-Z]+[.][a-z]{2,3}([.][a-z]{2}){0,1}$";
            try
            {
                if (Regex.IsMatch(email, emailID))
                {
                    Console.WriteLine("Email is matching with Regex");
                }
                else
                {
                    Console.WriteLine("Email is not matching Regex ");
                }
                return email;
            }
            catch (NullReferenceException)
            {
                throw new UserRegistratinException(ExceptionType.NULL_MAIL_ID, "Please do not Enter the Null Input");
            }
        }


        public string ValidatePhoneNumber(string phoneNumber)
        {
            //"91 9988123456"
            string phoneNum = @"[0-9]{2}[ ][0-9]{10}";  //@"[0-9]{2}/s[0-9]{10}" Both are correct expressions

            try
            {
                if (Regex.IsMatch(phoneNumber, phoneNum))
                {
                    Console.WriteLine("Phone Number is matching with regex");
                }
                else
                {
                    Console.WriteLine("Phone Number is not matching with Regex ");
                }
                return phoneNumber;
            }
            catch (NullReferenceException)
            {
                throw new UserRegistratinException(ExceptionType.NULL_PHONENUMBER, "Please do not Enter the Null Input");
            }
        }


        public string ValidatePassword(string pswrd)
        {
            string password = @"[A-Z]{1}[a-z0-9]";
            try
            {
                if (Regex.IsMatch(pswrd, password))
                {
                    Console.WriteLine("Password is matching with Regex");
                }
                else
                {
                    Console.WriteLine("Password is not matching with Regex");
                }
                return pswrd;
            }
            catch (NullReferenceException)
            {
                throw new UserRegistratinException(ExceptionType.NULL_PASSWORD, "Please do not Enter the Null Input");
            }
        }
        public string ValidateStringPassword(string numPassword)
        {
            string password = "[A-Z]{1,}[a-z0-9]";
            try
            { 
            if (Regex.IsMatch(numPassword, password))
            {
                Console.WriteLine("Numeric Password is matching with Regex");
            }
            else
            {
                Console.WriteLine("Numeric password is not matching with Regex");
            }
            return numPassword;
        }
        catch (NullReferenceException)
            {
                throw new UserRegistratinException(ExceptionType.NULL_PASSWORDRULE2, "Please do not Enter the Null Input");
    }
}
        public string ValidateNumericPassword(string numPassword)               //UC7
        {
            string password = "[a-zA-Z][0-9]{1,}";
            try
            {
                if (Regex.IsMatch(numPassword, password))
                {
                    Console.WriteLine("Numeric Password is matching with Regex");
                }
                else
                {
                    Console.WriteLine("Numeric password is not matching with Regex");
                }
                return numPassword;
            }
            catch (NullReferenceException)
            {
                throw new UserRegistratinException(ExceptionType.NULL_PASSWORDRULE3, "Please do not Enter the Null Input");
            }

        }
        public string ValidateSpecialCharacter(string character)
        {
            string spclChar = "[0-9a-zA-Z][!@#$%&*]{1}";
            try
            { 
            if (Regex.IsMatch(character, spclChar))
            {
                Console.WriteLine("Special Character is matched with Regex");
            }
            else
            {
                Console.WriteLine("Special Character is not matched with Regex");
            }
            return character;
        }
         catch (NullReferenceException)
            {
                throw new UserRegistratinException(ExceptionType.NULL_SPECIALCHAR, "Please do not Enter the Null Input");
    }

}
    }


}
