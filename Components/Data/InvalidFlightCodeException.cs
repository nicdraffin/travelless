using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travelless.Components.Data
{
    public class InvalidFlightCodeException : Exception
    {
        public InvalidFlightCodeException() : base("Invalid flight code provided") { }
        public InvalidFlightCodeException(string message) : base(message) { }
        public InvalidFlightCodeException(string message, Exception innerException) : base(message, innerException) { }
    }
}
