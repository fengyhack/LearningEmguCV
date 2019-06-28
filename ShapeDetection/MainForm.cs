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
using Emgu.CV.UI;
using Emgu.CV.Util;

namespace EmguCV.ShapeDetection
{
    public partial class MainForm : Form
    {
        private Image<Bgr, Byte> image0 = null;
        private Image<Gray, Byte> image_gray= null;
        private Image<Gray, Byte> image_canny = null;
        private Image<Bgr, Byte> image_lines = null;

        private double threshold = 100;
        private double threshLink = 50;
        private double rhoResolution = 1.0;
        private double thetaResolution_PI = 45.0;
        private int lineThreshold = 20;
        private double minLineWidth = 30;
        private double gapBetweenLines = 10;

        public MainForm()
        {
            InitializeComponent();
            textBox_Threshold.Text = threshold.ToString();
            textBox_ThreshLink.Text = threshLink.ToString();
            textBox_rhoResolution.Text = rhoResolution.ToString();
            textBox_thetaResolution.Text = thetaResolution_PI.ToString();
            textBox_lineThreshold.Text = lineThreshold.ToString();
            textBox_minLineWidth.Text = minLineWidth.ToString();
            textBox_gapBetweenLines.Text = gapBetweenLines.ToString();
        }

        private void button_LoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select an image file";
            ofd.Filter = "Image File|*.jpg;*.png;*.bmp;*.tif;*.gif|All File|*.*";
            ofd.Multiselect = false;
            if (DialogResult.OK == ofd.ShowDialog(this))
            {
                image0 = new Image<Bgr, Byte>(ofd.FileName);
                pictureBox1.Image = image0.ToBitmap();
            }
        }

        private void button_ToGray_Click(object sender, EventArgs e)
        {
            if (image0 == null)
            {
                MessageBox.Show("Please open an image first");
                return;
            }

            //image_gray = new Image<Gray, Byte>(image0.Size);
            //CvInvoke.cvCvtColor(image0, image_gray, Emgu.CV.CvEnum.COLOR_CONVERSION.BGR2GRAY);
            image_gray = image0.Convert<Gray, Byte>().PyrDown().PyrUp();
            pictureBox2.Image = image_gray.ToBitmap();
        }

        private void button_EdgeDetect_Click(object sender, EventArgs e)
        {
            if (image_gray == null)
            {
                MessageBox.Show("need grayscale first");
                return;
            }

            threshold = double.Parse(textBox_Threshold.Text);
            threshLink = double.Parse(textBox_ThreshLink.Text);

            image_canny = image_gray.Canny(threshLink, threshold);
            pictureBox2.Image = image_canny.ToBitmap();
        }

        private void button_HoughLines_Click(object sender, EventArgs e)
        {
            if(image_canny==null)
            {
                MessageBox.Show("Need canny first");
                return;
            }

            rhoResolution = double.Parse(textBox_rhoResolution.Text);
            thetaResolution_PI = double.Parse(textBox_thetaResolution.Text);
            lineThreshold = int.Parse(textBox_lineThreshold.Text);
            minLineWidth = double.Parse(textBox_minLineWidth.Text);
            gapBetweenLines = double.Parse(textBox_gapBetweenLines.Text);
            LineSegment2D[][] houghLines = image_canny.HoughLinesBinary(rhoResolution, 
                Math.PI/thetaResolution_PI, lineThreshold, minLineWidth, gapBetweenLines);

            image_lines = new Image<Bgr, Byte>(image_canny.Size);
            Bgr color=new Bgr(Color.DeepSkyBlue);
            foreach(LineSegment2D line in houghLines[0])
            {
                image_lines.Draw(line, color, 5);
            }
            pictureBox2.Image = image_lines.ToBitmap();
        }
    }
}
