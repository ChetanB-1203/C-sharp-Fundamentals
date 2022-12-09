using System;

namespace EventExample
{
    public class MailService
    {
        public void OnVideoEncoded(Object src , EventArgs args)
        {
            Console.WriteLine("Sending an email");
        }
    }
}
