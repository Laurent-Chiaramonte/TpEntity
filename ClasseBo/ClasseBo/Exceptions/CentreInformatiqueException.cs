using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseBo.Exceptions
{
    public class CentreInformatiqueException : TpException
    {
        public CentreInformatiqueException() { }

        public CentreInformatiqueException(string message) : base(message) { return; }

        public CentreInformatiqueException(string message, System.Exception inner) : base(message, inner) { }
    }
}
