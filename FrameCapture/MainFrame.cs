using System;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;

namespace FrameCapture
{
    partial class MainWindow
    {
        #region Members
        private Capture capture;
        private Image<Bgr, Byte> currentFrame;
        private Image<Bgr, Byte> previousFrame;
        private int frameCount;
        private  bool isCapturing;
        private int fps;
        private int frameWidth;
        private int frameHeight;
        private int totalFrameCount;
        private bool firstClicked;
        private bool isRecordCamVideo;
        private VideoWriter videoWriter;
        #endregion

        public MainWindow()
        {
            InitializeComponent();
            AssignEnventHandlers();
            AssignTabPages(null);

            capture = null;
            currentFrame = null;
            previousFrame = null;
            frameCount = 0;
            isCapturing = false;
        }

        private void AssignEnventHandlers()
        {
            FormClosed+=MainWindow_Closed;
            miCameraCapture.Click += miCameraCapture_Click;
            miVideoCapture.Click += miVideoCapture_Click;
            miImageCapture.Click += miImageCapture_Click;
            btnCameraCapture.Click+=btnCameraCapture_Click;
            labelStopCameraCapture.Click+=labelStopCameraCapture_Click;
            labelOpenVideoFile.Click+=labelOpenVideoFile_Click;
            labelStopVideoCapture.Click+=labelStopVideoCapture_Click;
            btnVideoCapture.Click+=btnVideoCapture_Click;
        }

        private void MainWindow_Closed(object sender,EventArgs e)
        {
            ReleaseData();
            base.OnClosed(e);
        }
        private void ReleaseData()
        {
            if(capture!=null)
            {
                capture.Dispose();
                capture = null;
            }
            firstClicked = true;
            isCapturing = false;
            frameCount = 0;
            totalFrameCount = 0;
        }

        private void AssignTabPages(TabPage page)
        {
            int count = tabCtrlMain.TabCount;
            for (int idx = count - 1; idx >= 1; --idx)
            {
                tabCtrlMain.TabPages.RemoveAt(idx);
            }

            if (page != null)
            {
                tabCtrlMain.TabPages.Add(page);
                tabCtrlMain.SelectedIndex = 1;
            }
        }

        private void miCameraCapture_Click(object sender, EventArgs e)
        {
            ReleaseData();
            AssignTabPages(tpCameraCapture);
            tabCtrlMain.TabPages.Add(tpResultPage);
            try
            {
                capture = new Capture();
                frameWidth = (int)capture.GetCaptureProperty(CAP_PROP.CV_CAP_PROP_FRAME_WIDTH);
                frameHeight = (int)capture.GetCaptureProperty(CAP_PROP.CV_CAP_PROP_FRAME_HEIGHT);
                fps = (int)capture.GetCaptureProperty(CAP_PROP.CV_CAP_PROP_FPS);
                previousFrame = new Image<Bgr, byte>(frameWidth, frameHeight);
                capture.ImageGrabbed += OnCameraCapture_ImageGrabbed;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void miVideoCapture_Click(object sender, EventArgs e)
        {
            ReleaseData();
            AssignTabPages(tpVideoCapture);
            tabCtrlMain.TabPages.Add(tpResultPage);
        }

        private void miImageCapture_Click(object sender, EventArgs e)
        {
            ReleaseData();
            AssignTabPages(tpImageCapture);
        }

        private void btnCameraCapture_Click(object sender, EventArgs e)
        {
            if (firstClicked)
            {
                firstClicked = false;
                isRecordCamVideo = checkBoxRecordCamVideo.Checked;
                if (isRecordCamVideo)
                {
                    string strFileName = DateTime.Now.ToString("yyyyMMddHHmmss") + ".avi";
                    if (fps <= 0 || fps >= 30) fps = 20;
                    //全帧非压缩,录制的视频体积巨大
                    //videoWriter = new VideoWriter(strFileName, fps, frameWidth, frameHeight, true);
                    videoWriter = new VideoWriter(strFileName, CvInvoke.CV_FOURCC('D', 'I', 'V', 'X'), fps, frameWidth, frameHeight, true);
                }
            }
            if (capture != null)
            {
                if (isCapturing)
                {
                    capture.Stop();
                    btnCameraCapture.Text = "Resume";
                    labelCameraCaptureStatus.Text = "Paused";
                }
                else
                {
                    capture.Start();
                    btnCameraCapture.Text = "Pause";
                    labelCameraCaptureStatus.Text = "Capturing";
                }
                isCapturing = !isCapturing;
            }
        }

        private void OnCameraCapture_ImageGrabbed(object sender, EventArgs e)
        {
            currentFrame = capture.RetrieveBgrFrame();
            if(currentFrame==null)
            {
                capture.Stop();
                capture.Dispose();
                return;
            }
            ++frameCount;
            if (isRecordCamVideo)
            {
                videoWriter.WriteFrame<Bgr, Byte>(currentFrame);
            }
            imageBoxCameraCapture.Image = currentFrame;
            imageBoxResult.Image = currentFrame.Sub(previousFrame);
            previousFrame = currentFrame.Copy(); //请使用'Copy'而不是'='       
            stripCameraCapture.BeginInvoke(new SetLabelText(SetStatusLabelText), labelCameraFrameCounter, frameCount);
        }

        public delegate void SetLabelText(ToolStripStatusLabel stripLabel, int frameCount);
        private void SetStatusLabelText(ToolStripStatusLabel stripLabel, int frameCount)
        {
            stripLabel.Text = "Frame:" + frameCount.ToString();
            if(totalFrameCount>0)
            {
                stripLabel.Text += "/" + totalFrameCount.ToString();
            }
        }

        private void labelStopCameraCapture_Click(object sender, EventArgs e)
        {
            imageBoxCameraCapture.Image = null;
            ReleaseData();
            btnCameraCapture.Text = "Start";
            labelCameraCaptureStatus.Text = "Ready";
            labelCameraFrameCounter.Text = "Frame:0";
            try
            {
                if(isRecordCamVideo)
                {
                    videoWriter.Dispose();
                    videoWriter = null;
                }
                capture = new Capture();
                isRecordCamVideo = checkBoxRecordCamVideo.Checked;
                capture.ImageGrabbed += OnCameraCapture_ImageGrabbed;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private void labelOpenVideoFile_Click(object sender, EventArgs e)
        {
            if(isCapturing)
            {
                MessageBox.Show("请先停止当前进行中的任务","提示");
                return;
            }

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select a Video file";
            ofd.Multiselect = false;
            ofd.Filter = "Video File(*.avi;*.mp4)|*.avi;*mp4;*.rmvb;*.mkv";
            DialogResult dr = ofd.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                try
                {
                    capture = new Capture(ofd.FileName);
                    fps = (int)capture.GetCaptureProperty(CAP_PROP.CV_CAP_PROP_FPS);
                    totalFrameCount=(int)capture.GetCaptureProperty(CAP_PROP.CV_CAP_PROP_FRAME_COUNT);
                    frameWidth = (int)capture.GetCaptureProperty(CAP_PROP.CV_CAP_PROP_FRAME_WIDTH);
                    frameHeight = (int)capture.GetCaptureProperty(CAP_PROP.CV_CAP_PROP_FRAME_HEIGHT);
                    labelVideoFPS.Text = "FPS:" + fps.ToString();
                    progressBarVideoCapture.Maximum = totalFrameCount;
                    previousFrame = new Image<Bgr, byte>(frameWidth, frameHeight);
                    capture.ImageGrabbed += OnVideoCapture_ImageGrabbed;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void labelStopVideoCapture_Click(object sender, EventArgs e)
        {
            imageBoxVideoCapture.Image = null;
            ReleaseData();
            btnVideoCapture.Text = "Start";
            labelVideoCaptureStatus.Text = "Ready";
            labelVideoFPS.Text = "FPS:0";
            labelVideoFrameCounter.Text = "Frame:0";
            progressBarVideoCapture.Value = 0;
            progressBarVideoCapture.Maximum = 100;
        }

        private void OnVideoCapture_ImageGrabbed(object sender, EventArgs e)
        {
            currentFrame = capture.RetrieveBgrFrame();
            if(currentFrame==null)
            {
                capture.Stop();
                return;
            }
            ++frameCount;
            imageBoxVideoCapture.Image = currentFrame;
            imageBoxResult.Image = currentFrame.Sub(previousFrame);
            previousFrame = currentFrame.Copy(); //请使用'Copy'而不是'='       
            stripVideoCapture.BeginInvoke(new SetLabelText(SetStatusLabelText), labelVideoFrameCounter, frameCount);
            progressBarVideoCapture.BeginInvoke(new PBValue(PBValueInc));
            System.Threading.Thread.Sleep((int)(1000 / fps));
        }

        public delegate void PBValue();
        private void PBValueInc()
        {
            int value = progressBarVideoCapture.Value;
            if (value < progressBarVideoCapture.Maximum)
            {
                progressBarVideoCapture.Value = value + 1;
            }
        }

        private void btnVideoCapture_Click(object sender, EventArgs e)
        {
            if (capture != null)
            {
                if (isCapturing)
                {
                    capture.Stop();
                    btnVideoCapture.Text = "Resume";
                    labelVideoCaptureStatus.Text = "Paused";
                }
                else
                {
                    capture.Start();
                    btnVideoCapture.Text = "Pause";
                    labelVideoCaptureStatus.Text = "Capturing";
                }
                isCapturing = !isCapturing;
            }
            else
            {
                MessageBox.Show("请先打开一个视频文件","提示");
            }
        }
    }
}