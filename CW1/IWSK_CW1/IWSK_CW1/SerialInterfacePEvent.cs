using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWSK_CW1
{
    class SerialInterfacePEvent : EventArgs
    {
        public bool DSR { get; }
        public bool CTS { get; }

        public SerialInterfacePEvent(bool dSR, bool cTS)
        {
            DSR = dSR;
            CTS = cTS;
        }
    }
}
