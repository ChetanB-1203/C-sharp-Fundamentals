using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventExample
{

    public delegate void VideoEncoderEventHandler(Object src, EventArgs args);
    public  class VideoEncoder
    {

        //define a delegate

        // define an event based on that delegate

        //raise an event 

        public event VideoEncoderEventHandler VideoEncoded;
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video");
            Thread.Sleep(3000);
            OnVideoEncoded();
        }

        protected virtual void OnVideoEncoded()
        {
            if(VideoEncoded!= null) 
                VideoEncoded(this,EventArgs.Empty); 

        }
    }
}
