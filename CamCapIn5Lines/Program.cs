using System;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.UI;


namespace EmguCV.CamCapIn5Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            ImageViewer viewer = new ImageViewer(); //创建图像视窗
            Capture capture = new Capture(); //创建摄像头捕获
            Application.Idle += new EventHandler(delegate(object sender, EventArgs e)
            {  // “Idle”处理循环的事件处理过程
                viewer.Image = capture.QueryFrame(); //在视窗中显示抓取的帧图像
            });
            viewer.ShowDialog(); //显示图像视窗
        }
    }
}
