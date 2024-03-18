using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travelless.Components.Data
{
    public class NoMoreSeatException : Exception
    {
        public NoMoreSeatException() : base("No more seats on this flight") { }
        public NoMoreSeatException(string message) : base(message) { }
        public NoMoreSeatException(string message, Exception innerException) : base(message, innerException) { }
    }
}
