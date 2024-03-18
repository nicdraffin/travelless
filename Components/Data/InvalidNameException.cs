﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travelless.Components.Data
{
    public class InvalidNameException : Exception
    {
        public InvalidNameException() : base("Invalid name provided") { }
        public InvalidNameException(string message) : base(message) { }
        public InvalidNameException(string message, Exception innerException) : base(message, innerException) { }
    }
}
