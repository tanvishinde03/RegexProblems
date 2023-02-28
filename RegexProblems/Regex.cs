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
            Console.ReadLine();
        }


    }
}
