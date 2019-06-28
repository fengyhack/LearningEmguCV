using System;
using System.Drawing; // Point,Size
using Emgu.CV;
using Emgu.CV.Structure; // Structure.Bgr, Structure.MCvFont
using Emgu.CV.CvEnum;  // CvEnum.FONT

namespace EmguCV.HelloWorld.ConsoleInvoke
{
    class Program
    {
        static void Main(string[] args)
        {
            // 新建窗体的名称(类名、标题)
            // 这个窗体与Console窗体不同，是一个独立的窗体
            string windowName = "Hello World";

            // 等价于OpenCV 中的 cvNamedWindow/ namedWindow
            CvInvoke.cvNamedWindow(windowName);

            // 泛型(模板), RGB彩色图像, 每个通道用一个Byte表示
            // 初始化一个背景图像400*200大小，画刷颜色RGB(0,0,255)纯蓝色
            Image<Bgr, Byte> image = new Image<Bgr, Byte>(400, 200, new Bgr(255, 0, 0));

            // 创建字体，内置的script手写体，水平/垂直方向缩放比例为1.0和1.0
            MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_SCRIPT_COMPLEX, 1.0, 1.0);

            // 在image图像上绘制消息字符串
            string message = "Hello World";

            // 方法Draw的多个重载版本之一:绘制字符串，起始位置(10,80)，颜色为纯白色
            image.Draw(message, ref font, new Point(10, 80), new Bgr(255, 255, 255));

            // 等价于cvShowImage/imshow
            CvInvoke.cvShowImage(windowName, image);

            // 等价于cvWaitKey/waitKey 等待按键输入，
            // waitKey(0)表示接受输入后立即返回（执行后续语句）
            CvInvoke.cvWaitKey(0);

            // 销毁窗口(销毁的是cvNamedWindow所创建的，而不是Console窗口)
            CvInvoke.cvDestroyWindow(windowName);
            // 销毁窗口后程序执行完毕退出(Console窗口也自然关闭了)
        }
    }
}
