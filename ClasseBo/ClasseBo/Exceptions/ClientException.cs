using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseBo.Exceptions
{
    public class ClientException  : TpException
    {
        public ClientException() { }

        public ClientException(string message) : base(message) { return; }

        public ClientException(string message, System.Exception inner) : base(message, inner) { }
    }
}
