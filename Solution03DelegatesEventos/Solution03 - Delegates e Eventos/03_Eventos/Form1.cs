using System;
using System.Windows.Forms;
using _03_Eventos.Lib;
using _03_Eventos.Lib.Mensageiro;

namespace _03_Eventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnVideoEncode.Click += EventoDeClick;
        }

        public void EventoDeClick(object sender, EventArgs e)
        {
            Video video = new Video() { Nome = "video.mp4" };

            VideoEncode vid = new VideoEncode();

            vid.Encoded += new Email().EnviarMensagem;
            vid.Encoded += new SMS().EnviarMensagem;

            vid.Encode(video);
        }
    }
}
