using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseBo.Exceptions
{
    public class ContratException : TpException
    {
        public ContratException() { }

        public ContratException(string message) : base(message) { return; }

        public ContratException(string message, System.Exception inner) : base(message, inner) { }
    }
}
