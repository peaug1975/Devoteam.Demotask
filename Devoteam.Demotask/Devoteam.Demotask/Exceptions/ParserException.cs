using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devoteam.Demotask.Exceptions
{
    public class ParserException: Exception
    {
        public ParserException() { }
        public ParserException(string message) : base(message) { }
    }
}
