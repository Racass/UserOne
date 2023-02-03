using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserOneLibrary.Exceptions
{
    public class InvalidAdapterException : Exception
    {
        public InvalidAdapterException() : base() { }
        public InvalidAdapterException(string message) : base(message)
        {
        }
    }
}
