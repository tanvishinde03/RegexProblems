using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProblems
{
    public class Program
    {
        static void Main(string[] args)
        {
            RegexProgram regex = new RegexProgram(null);
            regex.ValidateFirstName("Tanvi");
            regex.ValidateLastName("Shinde");
            regex.ValidateEmail("tanvi.shinde@gmail.co.in");
            regex.ValidatePhoneNumber("91 8007622250");
            regex.ValidatePassword("Password");
            regex.ValidateStringPassword("Tanvi123");
            regex.ValidateNumericPassword("tanU003");
            regex.ValidateSpecialCharacter("tanu@");
            Console.ReadLine();
        }
    }
}
