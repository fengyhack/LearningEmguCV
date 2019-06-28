using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Features2D;
using Emgu.CV.Util;
using Emgu.CV.XFeatures2D;
using System.Drawing;

namespace FASTDetector
{
    public class Program
    {
        static void Main(string[] args)
        {
            var image = new Image<Bgr, byte>("RGB.jpg").Resize(0.4, Inter.Area);
            var image_gray = image.Convert<Gray, byte>();
            //CvInvoke.CvtColor(image, image_gray, ColorConversion.Bgr2Gray);

            var fastDetector = new FastDetector(80);
            //var keyPoints = new VectorOfKeyPoint();
            var descriptors = new UMat();
            //fastDetector.DetectAndCompute(image_gray, null, keyPoints, descriptors, false);
            //Features2DToolbox.DrawKeypoints(image, keyPoints, image, new Bgr(255, 255, 0), Features2DToolbox.KeypointDrawType.DrawRichKeypoints);
            var keyPoints = fastDetector.Detect(image_gray);

            foreach (var point in keyPoints)
            {
                CvInvoke.Circle(image, new Point((int)point.Point.X, (int)point.Point.Y), 1, new MCvScalar(0, 0, 255, 255), 2);
            }
            CvInvoke.Imshow("result", image);
            CvInvoke.WaitKey();
        }
    }
}