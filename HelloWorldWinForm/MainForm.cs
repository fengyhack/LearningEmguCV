using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace EmguCV.HelloWorld.FormInvoke
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string windowName = "Hello EmguCV";
            string message="Hello World!";
            CvInvoke.cvNamedWindow(windowName);
            using(Image<Bgr,Byte> image=new Image<Bgr,byte>(400,300,new Bgr(255,255,255)))
            {
                MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_COMPLEX, 1.0, 1.0);
                image.Draw(message, ref font, new Point(100, 100), new Bgr(255, 0, 0));
                CvInvoke.cvShowImage(windowName,image);
                CvInvoke.cvWaitKey(0);
                CvInvoke.cvDestroyWindow(windowName);
            }
        }
    }
}
