using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWSK_CW1
{
    class SerialInterfaceEvent : EventArgs
    {
        public string data { get; }

        public SerialInterfaceEvent(string data)
        {
            this.data = data;
        }
    }
}
