using System;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;

namespace CameraCalibration
{
    static class CameraCalibration
    {
        static void Main(string[] args)
        {
            Console.Write("image(chessboard):");
            var filename = Console.ReadLine();
            CameraCalibrate(filename);
        }

        static void CameraCalibrate(string filename)
        {
            const int N = 1;
            const int Nx = 9;
            const int Ny = 6;
            const float square_size = 20.0f;
            const int Ncorners = Nx * Ny;
            var pattern_size = new Size(Nx, Ny);

            var color_image = new Image<Bgr, byte>(filename);
            var gray_image = color_image.Convert<Gray, byte>();
            
            // 角点位置坐标：物理坐标系
            var object_corners = new MCvPoint3D32f[N][];
            object_corners[0] = new MCvPoint3D32f[Ncorners];
            var k = 0;
            for (int r = 0; r < Ny; ++r)
            {
                for (int c = 0; c < Nx; ++c)
                {
                    object_corners[0][k++] =
                        new MCvPoint3D32f(
                            10.0f + square_size * (c + 1),
                            5.0f + square_size * (r + 1),
                            0.0f);
                }
            }

            // 角点位置坐标：图像坐标系
            var image_corners = new PointF[N][];
            var detected_corners = new VectorOfPointF();
            CvInvoke.FindChessboardCorners(gray_image, pattern_size, detected_corners);
            image_corners[0] = detected_corners.ToArray();
            gray_image.FindCornerSubPix(image_corners, new Size(5, 5), new Size(-1, -1), new MCvTermCriteria(30, 0.1));
            
            var cameraMatrix = new Mat();
            var distortionCoeffs = new Mat();
            var rotationVectors = new Mat[N];
            rotationVectors[0] = new Mat();
            var translationVectors = new Mat[N];
            translationVectors[0] = new Mat();

            CvInvoke.CalibrateCamera(
                object_corners,
                image_corners,
                gray_image.Size,
                cameraMatrix,
                distortionCoeffs,
                CalibType.RationalModel,
                new MCvTermCriteria(30, 0.1),
                out rotationVectors,
                out translationVectors);

            var calibrated_image = new Image<Bgr, byte>(color_image.Size);
            CvInvoke.Undistort(color_image, calibrated_image, cameraMatrix, distortionCoeffs);
            CvInvoke.DrawChessboardCorners(color_image, pattern_size, detected_corners, true);
            CvInvoke.Imshow("chessboard", color_image);
            CvInvoke.Imshow("calibrated", calibrated_image);
            CvInvoke.WaitKey();
        }
    }
}
