using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExample
{
    public class EventMain
    {
        static void Main(string[] args)
        {
            var video = new Video { Title = "video 1" };
            var videoEncoder = new VideoEncoder();
            var mailService = new MailService();
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.Encode(video);
            Console.ReadLine();
        }
    }
}
