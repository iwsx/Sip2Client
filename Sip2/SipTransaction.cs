using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sip2Service.SIP2
{
    public class SipTransaction
    {
        public string Message { get; set; }
        public string Response { get; set; }

        public override string ToString()
        {
            return string.Format("--> {0} \r\n<-- {1}\r\n", Message, Response);
        }
    }
}
