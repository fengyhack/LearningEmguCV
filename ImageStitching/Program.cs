using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Stitching;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageStitching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("image1:");

            var fa = Console.ReadLine().Replace("\"", "");
            Console.Write("image2:");
            var fb = Console.ReadLine().Replace("\"", "");

            var a = new Image<Bgr, byte>(fa);//.Resize(0.4, Inter.Area);
            var b = new Image<Bgr, byte>(fb);//.Resize(0.4, Inter.Area);
            var width = a.Width + b.Width + 20;
            var height = a.Height > b.Height ? a.Height : b.Height;
            var bmp = new Bitmap(width, height);
            var g = Graphics.FromImage(bmp);
            g.DrawImage(a.Bitmap, 0, 0, a.Width, a.Height);
            g.FillRectangle(Brushes.LightGreen, a.Width, 0, 20, height);
            g.DrawImage(b.Bitmap, a.Width + 20, 0, b.Width, b.Height);
            var pano = new Image<Bgr, byte>(bmp);
            CvInvoke.Imshow("result", pano);
            CvInvoke.WaitKey();
            pano.Save("result.jpg");
        }
    }
}