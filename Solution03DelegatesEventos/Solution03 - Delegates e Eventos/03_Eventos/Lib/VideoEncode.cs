using System;
using System.Threading;

namespace _03_Eventos.Lib
{
    public class VideoEncode
    {
        //public delegate void VideoEncodedHandler(Video video);
        //public event VideoEncodedHandler Encoded;

        public event EventHandler<VideoEventArgs> Encoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Convertendo o vídeo...");
            Thread.Sleep(2000);
            Console.WriteLine("Vídeo convertido!!");

            Encoded(this, new VideoEventArgs() { Video = video });
        }
    }

    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
}
