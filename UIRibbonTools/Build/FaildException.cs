using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UIRibbonTools
{
    public class FaildException : Exception
    {
        public FaildException(string message) : base(message) { }
    }
}
