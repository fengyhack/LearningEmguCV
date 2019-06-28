using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Stitching;
using Emgu.CV.Structure;

namespace EmguCV.Stitching
{
   public partial class StitchingMainForm : Form
   {
       private Image<Bgr, Byte>[] sourceImages=null;
      public StitchingMainForm()
      {
         InitializeComponent();
      }

      private void selectImagesButton_Click(object sender, EventArgs e)
      {
         OpenFileDialog dlg = new OpenFileDialog();
         dlg.CheckFileExists = true;
         dlg.Multiselect = true;

         if (dlg.ShowDialog(this) == DialogResult.OK)
         {
            sourceImageDataGridView.Rows.Clear();
            int count = dlg.FileNames.Length;
            sourceImages = new Image<Bgr, byte>[count];
            
            for (int i = 0; i < count; i++)
            {
                sourceImages[i] = new Image<Bgr, byte>(dlg.FileNames[i]);

               using (Image<Bgr, byte> thumbnail =sourceImages[i].Resize(200, 200, INTER.CV_INTER_CUBIC, true))
               {
                  DataGridViewRow row = sourceImageDataGridView.Rows[sourceImageDataGridView.Rows.Add()];
                  row.Cells["FileNameColumn"].Value = dlg.FileNames[i];
                  row.Cells["ThumbnailColumn"].Value = thumbnail.ToBitmap();
                  row.Height = 200;
               }
            }

            try
            {
               using (Stitcher stitcher = new Stitcher(true))
               {
                  //Image<Bgr, Byte> result = stitcher.Stitch(sourceImages);
                  //resultImageBox.Image = result;
               }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
               foreach (Image<Bgr, Byte> img in sourceImages)
               {
                  img.Dispose();
               }
            }
         }
      }
   }
}
