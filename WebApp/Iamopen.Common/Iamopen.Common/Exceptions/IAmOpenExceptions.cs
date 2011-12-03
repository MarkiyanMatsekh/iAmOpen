using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iamopen.Common.Exceptions
{
    public class IAmOpenException : Exception
	{
        public IAmOpenException(string message) : base(message)
        {
        }
	}
}
