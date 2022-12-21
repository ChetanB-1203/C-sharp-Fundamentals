using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_principle
{
    public  class NotificationBySetterInjection
    {
        private IMessenger _messenger;

        public NotificationBySetterInjection()
        {

        }
         public IMessenger MessageService
        {
            
            set
            {
                _messenger = value;
            }

            
        }
        public void DoNotify()
        {
            _messenger.SendMessage();
        }

    }
}
