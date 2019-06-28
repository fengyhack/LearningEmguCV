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

namespace EmguCV.GenericOperation
{
    public partial class MainForm : Form
    {
        private Image<Bgr, Byte> image0 = null;
        private Image<Gray, Byte> image1 = null;
        private Image<Gray, Single> image2 = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void button_OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select an image file";
            ofd.Filter = "Image File|*.jpg;*.png;*.bmp;*.tif;*.gif|All File|*.*";
            ofd.Multiselect = false;
            if(DialogResult.OK==ofd.ShowDialog(this) )
            {
                image0 = new Image<Bgr, Byte>(ofd.FileName);
                pictureBox1.Image = image0.ToBitmap();
            }
        }

        private void button_ToGray_Click(object sender, EventArgs e)
        {
            if (image0==null)
            {
                MessageBox.Show("Please open an image first");
                return;
            }
            image1 = image0.Convert<Gray, Byte>();
            pictureBox1.Image = image1.ToBitmap();
        }

        private void button_SineTrans_Click(object sender, EventArgs e)
        {
            if (image1==null)
            {
                MessageBox.Show("Please convert the image to grayscale first");
                return;
            }

            image2 = image1.Convert<Single>(delegate(Byte b) { return (Single)Math.Sin(b * b / 255.0); });
            pictureBox1.Image = image2.ToBitmap();
        }

        private void button_SaveAs_Click(object sender, EventArgs e)
        {
            if(image0==null)
            {
                MessageBox.Show("Please open an image first");
                return;
            }


            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save image as...";
            sfd.Filter = "Bitmap file|*.bmp";
            DialogResult dr=sfd.ShowDialog(this);
            if (dr != DialogResult.OK) return;
            if (image2 != null)
            {
                Bitmap bmp = image2.ToBitmap();
                bmp.Save(sfd.FileName);
            }
            else if(image1!=null)
            {
                image1.Save(sfd.FileName);
            }
            else
            {
                image0.Save(sfd.FileName);
            }
        }

        private void button_InvertColor_Click(object sender, EventArgs e)
        {
            int i, j;
            int w = image0.Width;
            int h = image0.Height;
            Image<Bgr, Byte> dest = new Image<Bgr, byte>(w, h);
            for(i=0;i<h;++i)
            {
                for(j=0;j<w;++j)
                {
                    Bgr cr = image0[i, j];
                    dest[i, j] = new Bgr(255-cr.Green, cr.Blue, cr.Red);
                }
            }

            pictureBox1.Image = dest.ToBitmap();
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save image as...";
            sfd.Filter = "Bitmap file|*.bmp";
            DialogResult dr = sfd.ShowDialog(this);
            if (dr != DialogResult.OK) return;
            dest.Save(sfd.FileName);
        }
    }
}
