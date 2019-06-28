using System;
using System.Drawing;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Features2D;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using Emgu.CV.XFeatures2D;

namespace FeatureMatching
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("image1:");
            var fa = Console.ReadLine().Replace("\"", "");
            Console.Write("image2:");
            var fb = Console.ReadLine().Replace("\"", "");

            var a = (new Image<Bgr, byte>(fa).Resize(0.2, Inter.Area)).SubR(new Bgr(255, 255, 255));
            var b = new Image<Bgr, byte>(fb).Resize(0.2, Inter.Area);            

            Mat homography = null;
            Mat mask = null;
            var modelKeyPoints = new VectorOfKeyPoint();
            var observedKeyPoints = new VectorOfKeyPoint();
            var matches = new VectorOfVectorOfDMatch();

            UMat a1 = a.Mat.ToUMat(AccessType.Read);
            UMat b1 = b.Mat.ToUMat(AccessType.Read);

            SURF surf = new SURF(300);
            UMat modelDescriptors = new UMat();
            UMat observedDescriptors = new UMat();

            surf.DetectAndCompute(a1, null, modelKeyPoints, modelDescriptors, false);       //进行检测和计算，把opencv中的两部分和到一起了，分开用也可以
            surf.DetectAndCompute(b1, null, observedKeyPoints, observedDescriptors, false);

            var matcher = new BFMatcher(DistanceType.L2);       //开始进行匹配
            matcher.Add(modelDescriptors);
            matcher.KnnMatch(observedDescriptors, matches, 2, null);
            mask = new Mat(matches.Size, 1, DepthType.Cv8U, 1);
            mask.SetTo(new MCvScalar(255));
            Features2DToolbox.VoteForUniqueness(matches, 0.8, mask);   //去除重复的匹配

            int Count = CvInvoke.CountNonZero(mask);      //用于寻找模板在图中的位置
            if (Count >= 4)
            {
                Count = Features2DToolbox.VoteForSizeAndOrientation(modelKeyPoints, observedKeyPoints, matches, mask, 1.5, 20);
                if (Count >= 4)
                {
                    homography = Features2DToolbox.GetHomographyMatrixFromMatchedFeatures(modelKeyPoints, observedKeyPoints, matches, mask, 2);
                }
            }

            //CvInvoke.Imshow("a", a);
            //CvInvoke.Imshow("b", b);

            Mat result = new Mat();
            //Features2DToolbox.DrawMatches(a.Convert<Gray, byte>().Mat, modelKeyPoints, b.Convert<Gray, byte>().Mat, observedKeyPoints, matches, result, new MCvScalar(255, 0, 255), new MCvScalar(0, 255, 255), mask);
            Features2DToolbox.DrawMatches(a, modelKeyPoints, b, observedKeyPoints, matches, result, new MCvScalar(0, 0, 255), new MCvScalar(0, 255, 255), mask);
            //绘制匹配的关系图
            //if (homography != null)     //如果在图中找到了模板，就把它画出来
            //{
            //    Rectangle rect = new Rectangle(Point.Empty, a.Size);
            //    PointF[] points = new PointF[]
            //    {
            //      new PointF(rect.Left, rect.Bottom),
            //      new PointF(rect.Right, rect.Bottom),
            //      new PointF(rect.Right, rect.Top),
            //      new PointF(rect.Left, rect.Top)
            //    };
            //    points = CvInvoke.PerspectiveTransform(points, homography);
            //    Point[] points2 = Array.ConvertAll<PointF, Point>(points, Point.Round);
            //    VectorOfPoint vp = new VectorOfPoint(points2);
            //    CvInvoke.Polylines(result, vp, true, new MCvScalar(255, 0, 0, 255), 15);
            //}

            CvInvoke.Imshow("result", result);
            CvInvoke.WaitKey();

            //Console.ReadLine();

        }
    }
}
