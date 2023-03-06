using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexProblems
{
    public class UserRegistratinException:Exception
    {
        public enum ExceptionType
        {
            NULL_FIRSTNAME,
            NULL_LASTNAME,
        }
        public ExceptionType Type;
        public UserRegistratinException(ExceptionType Type,string message): base (message)
        {
            this.Type = Type;
        }

    }
}
