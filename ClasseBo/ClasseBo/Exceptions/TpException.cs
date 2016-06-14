using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseBo.Exceptions
{
    public class TpException : SystemException
    {
        public TpException() { }

        public TpException(string message) : base(message) { return; }

        public TpException(string message, System.Exception inner) : base(message, inner) { }
    }
}
