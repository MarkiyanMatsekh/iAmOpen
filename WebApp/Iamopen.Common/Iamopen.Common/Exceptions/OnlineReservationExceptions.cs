using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iamopen.Common.Exceptions
{
    public class DBIncompatibilityException : IAmOpenException
	{
        public DBIncompatibilityException(string message) : base(message)
        {
        }
	}
}
