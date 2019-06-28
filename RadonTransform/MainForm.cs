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
using Emgu.CV.UI;
using System.Drawing.Imaging;

namespace RadonTransform
{
    public partial class MainForm : Form
    {
        private Image<Bgr, Byte> sourceImage = null;
        private Image<Gray, Byte> grayImage = null;
        private Image<Gray, Byte> cannyImage = null;
        private Image<Gray, Byte> radonImage = null;

        public MainForm()
        {
            InitializeComponent();
            button_Gray.Enabled = false;
            button_Canny.Enabled = false;
            button_Radon.Enabled = false;
        }

        private void button_OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "选择图像文件";
            ofd.Multiselect = false;
            ofd.Filter = "Image|*.jpg;*.png;*.bmp;*,tif;*.gif|All|*.*";
            if(ofd.ShowDialog()==DialogResult.OK)
            {
                sourceImage = new Image<Bgr, Byte>(ofd.FileName);
                textBox_fileName.Text = ofd.FileName;
            }
            pictureBox1.Image = sourceImage.ToBitmap();
            button_Gray.Enabled = true;
        }

        private void button_Gray_Click(object sender, EventArgs e)
        {
            grayImage = sourceImage.Convert<Gray, Byte>();
            pictureBox2.Image = grayImage.ToBitmap();
            button_Canny.Enabled = true;
            button_Gray.Enabled = false;
        }

        private void button_Canny_Click(object sender, EventArgs e)
        {
            cannyImage = grayImage.Canny(10, 150);
            pictureBox2.Image = cannyImage.ToBitmap();
            button_Radon.Enabled = true;
            button_Canny.Enabled = false;
        }

        private void button_Radon_Click(object sender, EventArgs e)
        {
            Radon();
            button_Radon.Enabled = false;
        }

        private void Radon()
        {
            //
            MessageBox.Show("TBD-Radon");
        }
    }
}
