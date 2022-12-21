using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_principle
{
    public  class NotificationByConstructorInjection
    {   
        //here i am using construction injection so it  forms loose coupling
        private IMessenger _messenger;
        public NotificationByConstructorInjection(IMessenger pMessenger)
        {
            _messenger = pMessenger;
        }

        public void DoNotify()
        {
            _messenger.SendMessage();
        }
    }
}
