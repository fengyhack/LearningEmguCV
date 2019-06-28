using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using Emgu.CV.Util;
using Emgu.CV.UI;

namespace EmguCV.FaceDetection
{
    public partial class MainForm : Form
    {
        private Capture capture = null;
        Image<Bgr, byte> frame = null;
        private long totalNumFrame = 0;
        private int fps = 0;
        private CascadeClassifier cac = null;

        public MainForm()
        {
            InitializeComponent();
            cac=new CascadeClassifier("haarcascade_frontalface_alt2.xml");
        }

        private void button_OpenCamera_Click(object sender, EventArgs e)
        {
            capture = new Capture(0);
            fps = 10;
            capture.Start();
            capture.ImageGrabbed += FrameProcess;
        }

        private void button_StopCapture_Click(object sender, EventArgs e)
        {
            if(capture!=null)
            {
                capture.Stop();
                capture.Dispose();
                pictureBox1.Image = null;
            }
        }

        private void button_OpenVideo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Choose a video file";
            ofd.Multiselect = false;
            ofd.Filter = "Video File|*.avi;*.mp4;*.wmv;*.flv|All file|*.*";
            if(DialogResult.OK==ofd.ShowDialog(this))
            {
                capture = new Capture(ofd.FileName);
                totalNumFrame = (long)(capture.GetCaptureProperty(CAP_PROP.CV_CAP_PROP_FRAME_COUNT));
                fps = (int)(capture.GetCaptureProperty(CAP_PROP.CV_CAP_PROP_FPS));
                capture.ImageGrabbed += FrameProcess;
            }
        }

        private void FrameProcess(object sender, EventArgs e)
        {
            frame = capture.RetrieveBgrFrame();
            // there's only one channel (greyscale), hence the zero index
            //var faces = nextFrame.DetectHaarCascade(haar)[0];
            Image<Gray, byte> grayframe = frame.Convert<Gray, byte>();
            Rectangle[] faces = cac.DetectMultiScale(grayframe, 1.5, 2, new Size(20, 20), new Size(200, 200));
                    
            foreach (Rectangle face in faces)
            {
                frame.Draw(face, new Bgr(255,0,0), 3);
            }
            pictureBox1.Image = frame.ToBitmap();
            System.Threading.Thread.Sleep(1000 / fps);
        }

    }
}
