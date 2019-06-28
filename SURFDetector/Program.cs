using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Features2D;
using Emgu.CV.Structure;
using Emgu.CV.XFeatures2D;

namespace SURFDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            var image = new Image<Bgr, byte>("RGB.jpg").Resize(0.4, Inter.Area);
            var image_gray = image.Convert<Gray, byte>();
            var surfDetector = new SURF(1000);
            var keyPoints = surfDetector.Detect(image_gray);

            foreach (var point in keyPoints)
            {
                CvInvoke.Circle(image, new Point((int)point.Point.X, (int)point.Point.Y), 1, new MCvScalar(0, 0, 255, 255), 2);
            }
            CvInvoke.Imshow("result", image);
            CvInvoke.WaitKey();
        }
    }
}