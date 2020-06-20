using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscalonadorApp
{
    public class Event
    {

        public delegate void EventNotificationCPU(StatusCPU statusCPU);
        public static event EventNotificationCPU NotifyCPU;

        public delegate void EventNotificationProcesso();
        public static event EventNotificationProcesso NotifyProcesso;

        public static void SendProcesso()
        {
            if (NotifyProcesso == null)
                return;

            NotifyProcesso();
        }

        public static void SendCPU(StatusCPU statusCPU)
        {
            if (NotifyCPU == null)
                return;

            NotifyCPU(statusCPU);
        }
    }
}
