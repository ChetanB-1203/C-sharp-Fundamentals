﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_principle
{
    public class SMS : IMessenger
    {
        public void SendMessage()
        {
            Console.WriteLine("sending by SMS");
        }
    }
}
