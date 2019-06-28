using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV.UI;

namespace FrameCapture
{
    partial class MainWindow:Form
    {
        private IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(MainWindow));

            #region CreateNewItems
            //MainWindow
            panelMain = new Panel();
            menuBar = new StatusStrip();
            btnWorkMode = new ToolStripDropDownButton();
            miCameraCapture = new ToolStripMenuItem();
            miVideoCapture = new ToolStripMenuItem();
            miImageCapture = new ToolStripMenuItem();
            //TabControl
            tabCtrlMain = new TabControl();
            tpHomePage = new TabPage();
            tpCameraCapture = new TabPage();
            tpVideoCapture = new TabPage();
            tpImageCapture = new TabPage();
            //CameraPage         
            btnCameraCapture = new Button();
            checkBoxRecordCamVideo = new CheckBox();
            labelRecordCamVideo = new Label();
            stripCameraCapture = new StatusStrip();
            labelCameraCaptureStatus = new ToolStripStatusLabel();
            labelCameraFrameCounter = new ToolStripStatusLabel();
            labelStopCameraCapture = new ToolStripStatusLabel();
            imageBoxCameraCapture = new ImageBox();       
            //VideoPage
            btnVideoCapture = new Button();
            stripVideoCapture = new StatusStrip();
            labelOpenVideoFile = new ToolStripStatusLabel();
            labelStopVideoCapture = new ToolStripStatusLabel();
            labelVideoFPS = new ToolStripStatusLabel();
            labelVideoFrameCounter = new ToolStripStatusLabel();          
            labelVideoCaptureStatus = new ToolStripStatusLabel();
            progressBarVideoCapture = new ProgressBar();
            imageBoxVideoCapture = new ImageBox();       
            //ImagePage
            /////
            //ResultPage
            tpResultPage = new TabPage();
            imageBoxResult = new ImageBox();
            //
            #endregion

            #region SuspendLayouts
            //////
            //SuspendLayout
            panelMain.SuspendLayout();
            menuBar.SuspendLayout();
            tabCtrlMain.SuspendLayout();
            tpHomePage.SuspendLayout();
            tpCameraCapture.SuspendLayout();
            btnCameraCapture.SuspendLayout();
            checkBoxRecordCamVideo.SuspendLayout();
            labelRecordCamVideo.SuspendLayout();
            stripCameraCapture.SuspendLayout();
            ((ISupportInitialize)(imageBoxCameraCapture)).BeginInit();
            tpVideoCapture.SuspendLayout();
            btnVideoCapture.SuspendLayout();
            stripVideoCapture.SuspendLayout();
            progressBarVideoCapture.SuspendLayout();
            ((ISupportInitialize)(imageBoxVideoCapture)).BeginInit();
            tpImageCapture.SuspendLayout();
            tpResultPage.SuspendLayout();
            ((ISupportInitialize)(imageBoxResult)).BeginInit();
            SuspendLayout();
            #endregion

            #region PanelMain
            // panelMain
            panelMain.Name = "panelMain";
            panelMain.Location = new Point(0, 0);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Controls.Add(menuBar);
            panelMain.Controls.Add(tabCtrlMain);
            #endregion

            #region MenuBar
            // menuBar
            menuBar.Name = "menuBar";
            menuBar.Text = "menuBar";
            menuBar.Location = new Point(0, 0);
            menuBar.Dock = DockStyle.Top;
            menuBar.Items.AddRange(new ToolStripItem[] { btnWorkMode});        
            // btnWorkMode
            btnWorkMode.Name = "btnWorkMode";
            btnWorkMode.Text = "WorkMode";
            btnWorkMode.Size = new Size(120, 25); //按钮宽和高
            //btnWorkMode.Image = ((Image)(resources.GetObject("btnWorkMode.Image")));
            btnWorkMode.ImageTransparentColor = Color.Magenta;
            btnWorkMode.DropDownItems.AddRange(
                new ToolStripItem[] { 
                    miCameraCapture,
                    miVideoCapture,
                    miImageCapture});

            //menuItem
            miCameraCapture.Name = "miCameraCapture";
            miCameraCapture.Text = "CameraCapture";
            miCameraCapture.Size = new Size(120, 25);
            //menuItem
            miVideoCapture.Name = "miVideoCapture";
            miVideoCapture.Text = "VideoCapture";
            miVideoCapture.Size = new Size(120, 25);
            //menuItem
            miImageCapture.Name = "miImageCapture";
            miImageCapture.Text = "ImageCapture";
            miImageCapture.Size = new Size(120, 25);
            #endregion

            #region TabControl
            // tabCtrlMain
            tabCtrlMain.Name = "tabCtrlMain";
            tabCtrlMain.Location = new Point(0, 25);
            tabCtrlMain.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
            tabCtrlMain.Controls.Add(tpHomePage);
            tabCtrlMain.Controls.Add(tpCameraCapture);
            tabCtrlMain.Controls.Add(tpVideoCapture);
            tabCtrlMain.Controls.Add(tpImageCapture);
            tabCtrlMain.Controls.Add(tpResultPage);
            tabCtrlMain.SelectedIndex = 0;
            #endregion

            #region HomePage
            // tpHomePage
            tpHomePage.Name = "HomePage";
            tpHomePage.Text = "Home";
            tpHomePage.Location = new Point(5, 25);
            tpHomePage.Padding = new Padding(3);
            tpHomePage.BackColor = Color.LightBlue;
            #endregion

            #region CameraPage
            // tpCameraCapture 
            tpCameraCapture.Name = "CameraCapture";
            tpCameraCapture.Text = "Camera";
            tpCameraCapture.Location = new Point(5, 25);
            tpCameraCapture.Padding = new Padding(3);
            tpCameraCapture.AutoScroll = true;
            tpCameraCapture.AutoScrollMinSize = new Size(800, 600);
            tpCameraCapture.BackColor = Color.SkyBlue;
            tpCameraCapture.Controls.Add(btnCameraCapture);
            tpCameraCapture.Controls.Add(checkBoxRecordCamVideo);
            tpCameraCapture.Controls.Add(labelRecordCamVideo);
            tpCameraCapture.Controls.Add(stripCameraCapture);
            tpCameraCapture.Controls.Add(imageBoxCameraCapture);
            // btnCameraCapture
            btnCameraCapture.Name = "btnCameraCapture";
            btnCameraCapture.Text = "Start";
            btnCameraCapture.Location = new Point(10, 5);
            btnCameraCapture.Size = new Size(80, 25);
            btnCameraCapture.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            btnCameraCapture.UseVisualStyleBackColor = true;
            btnCameraCapture.ForeColor = Color.DarkBlue;
            btnCameraCapture.TabIndex = 0;
            //
            checkBoxRecordCamVideo.Name = "cbRecordCamVideo";
            checkBoxRecordCamVideo.Location = new Point(165, 7);
            checkBoxRecordCamVideo.Size = new Size(16, 16);
            checkBoxRecordCamVideo.Checked = false;
            checkBoxRecordCamVideo.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            labelRecordCamVideo.Name = "labelRecordCamVideo";
            labelRecordCamVideo.Location = new Point(180, 10);
            labelRecordCamVideo.Size = new Size(80, 20);
            labelRecordCamVideo.Text = "RecordVideo";
            labelRecordCamVideo.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            // stripCameraCapture
            stripCameraCapture.Name = "stripCameraCapture";
            stripCameraCapture.Text = "stripCameraCapture";
            stripCameraCapture.Location = new Point(600, 5);
            stripCameraCapture.Size = new Size(160, 25);
            stripCameraCapture.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            stripCameraCapture.BackColor = Color.LightGreen;
            stripCameraCapture.Items.AddRange(
                new ToolStripItem[] {
                    labelCameraCaptureStatus,
                    labelCameraFrameCounter,
                    labelStopCameraCapture});
            // labelCameraCaptureStatus
            labelCameraCaptureStatus.Name = "labelCameraCaptureStatus";
            labelCameraCaptureStatus.Text = "Ready";
            labelCameraCaptureStatus.Size = new Size(50, 25);
            // labelCameraFrameCounter
            labelCameraFrameCounter.Name = "labelCameraFrameCounter";
            labelCameraFrameCounter.Text = "Frame:0";
            labelCameraFrameCounter.Size = new Size(100, 25);
            // labelStopCameraCapture
            labelStopCameraCapture.Name = "labelStopCameraCapture";
            labelStopCameraCapture.Text = "Stop";
            labelStopCameraCapture.Size = new Size(50, 25);
            labelStopCameraCapture.BackColor = Color.Pink;
            labelStopCameraCapture.IsLink = true;
            // imageBoxCameraCapture
            imageBoxCameraCapture.Name = "imageBoxCameraCapture";
            imageBoxCameraCapture.Location = new Point(5, 40);
            imageBoxCameraCapture.Size = new Size(780, 520);
            imageBoxCameraCapture.Anchor =
                AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            imageBoxCameraCapture.BackColor = Color.Silver;
            imageBoxCameraCapture.SizeMode = PictureBoxSizeMode.CenterImage;
            imageBoxCameraCapture.TabStop = false;
            #endregion

            #region VideoPage
            // tpVideoCapture 
            tpVideoCapture.Name = "tpVideoCapture";
            tpVideoCapture.Text = "Video";
            tpVideoCapture.Location = new Point(5, 25);
            tpVideoCapture.Padding = new Padding(3);
            tpVideoCapture.AutoScroll = true;
            tpVideoCapture.AutoScrollMinSize = new Size(800, 600);
            tpVideoCapture.BackColor = Color.SkyBlue;
            tpVideoCapture.Controls.Add(btnVideoCapture);
            tpVideoCapture.Controls.Add(stripVideoCapture);
            //
            tpVideoCapture.Controls.Add(progressBarVideoCapture);
            //
            tpVideoCapture.Controls.Add(imageBoxVideoCapture);
            // btnVideoCapture
            btnVideoCapture.Name = "btnVideoCapture";
            btnVideoCapture.Text = "Start";
            btnVideoCapture.Location = new Point(10, 5);
            btnVideoCapture.Size = new Size(80, 25);
            btnVideoCapture.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnVideoCapture.UseVisualStyleBackColor = true;
            btnVideoCapture.ForeColor = Color.DarkBlue;
            // stripVideoCapture
            stripVideoCapture.Name = "stripVideoCapture";
            stripVideoCapture.Text = "stripVideoCapture";
            stripVideoCapture.Location = new Point(590, 5);
            stripVideoCapture.Size = new Size(170, 25);
            stripVideoCapture.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            stripVideoCapture.BackColor = Color.LightGreen;
            stripVideoCapture.Items.AddRange(
                new ToolStripItem[] {
                    labelVideoCaptureStatus,
                    labelVideoFPS,                  
                    labelVideoFrameCounter,
                    labelOpenVideoFile,
                    labelStopVideoCapture
                     });
            // labelVideoCaptureStatus
            labelVideoCaptureStatus.Name = "labelVideoCaptureStatus";
            labelVideoCaptureStatus.Text = "Ready";
            labelVideoCaptureStatus.Size = new Size(50, 25);
            // labelVideoFPS
            labelVideoFPS.Name = "labelVideoFPS";
            labelVideoFPS.Size = new Size(30, 25);
            labelVideoFPS.Text = "FPS:0";      
            // labelVideoFrameCounter
            labelVideoFrameCounter.Name = "labelVideoFrameCounter";
            labelVideoFrameCounter.Size = new Size(100, 25);
            labelVideoFrameCounter.Text = "Frame:0";
            // labelOpenVideoFile
            labelOpenVideoFile.Name = "labelOpenVideoFile";
            labelOpenVideoFile.Text = "Open";
            labelOpenVideoFile.Size = new Size(50, 25);
            labelOpenVideoFile.BackColor = Color.Lime;
            labelOpenVideoFile.IsLink = true;
            // labelStopVideoCapture
            labelStopVideoCapture.Name = "labelStopVideoCapture";
            labelStopVideoCapture.Text = "Stop";
            labelStopVideoCapture.Size = new Size(50, 25);
            labelStopVideoCapture.BackColor = Color.Pink;
            labelStopVideoCapture.IsLink = true;
            ///
            //
            progressBarVideoCapture.Name = "progressBarVideoCapture";
            progressBarVideoCapture.Location = new Point(5, 32);
            progressBarVideoCapture.Size = new Size(780, 7);
            progressBarVideoCapture.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // imageBoxVideoCapture
            imageBoxVideoCapture.Name = "imageBoxVideoCapture";
            imageBoxVideoCapture.Location = new Point(5, 40);
            imageBoxVideoCapture.Size = new Size(780, 520);
            imageBoxVideoCapture.Anchor =
                AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            imageBoxVideoCapture.BackColor = Color.Silver;
            imageBoxVideoCapture.SizeMode = PictureBoxSizeMode.CenterImage;
            imageBoxVideoCapture.TabStop = false;
            #endregion

            #region ImagePage
            // tpImageCapture
            tpImageCapture.Name = "tpImageCapture";
            tpImageCapture.Text = "Image";
            tpImageCapture.Location = new Point(5, 25);
            tpImageCapture.Padding = new Padding(3);
            tpImageCapture.Size = new Size(800,600);
            tpImageCapture.BackColor = Color.SkyBlue;
            #endregion

            #region ResultPage
            tpResultPage.Name = "tpResultPage";
            tpResultPage.Text = "Result";
            tpResultPage.Location = new Point(5, 25);
            tpResultPage.Padding = new Padding(3);
            tpResultPage.AutoScroll = true;
            tpResultPage.AutoScrollMinSize = new Size(800, 600);
            tpResultPage.BackColor = Color.SkyBlue;
            tpResultPage.Controls.Add(imageBoxResult);
            imageBoxResult.Name = "imageBoxResult";
            imageBoxResult.Location = new Point(5, 40);
            imageBoxResult.Size = new Size(780, 520);
            imageBoxResult.Anchor =
                AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            imageBoxResult.BackColor = Color.Silver;
            imageBoxResult.SizeMode = PictureBoxSizeMode.CenterImage;
            imageBoxResult.TabStop = false;
            #endregion

            #region PerformLayouts
            // MainForm
            Name = "MainWindow";
            Text = "FrameCapture";
            StartPosition = FormStartPosition.CenterScreen;
            ClientSize = new Size(880, 620);
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(this.panelMain);

            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            menuBar.ResumeLayout(false);
            menuBar.PerformLayout();
            tabCtrlMain.ResumeLayout(false);
            tpHomePage.ResumeLayout(false);
            tpHomePage.PerformLayout();
            tpCameraCapture.ResumeLayout(false);
            tpCameraCapture.PerformLayout();
            btnCameraCapture.ResumeLayout(false);
            btnCameraCapture.PerformLayout();
            checkBoxRecordCamVideo.ResumeLayout(false);
            checkBoxRecordCamVideo.PerformLayout();
            labelRecordCamVideo.ResumeLayout(false);
            labelRecordCamVideo.PerformLayout();
            stripCameraCapture.ResumeLayout(false);
            stripCameraCapture.PerformLayout();
            ((ISupportInitialize)(imageBoxCameraCapture)).EndInit();
            tpVideoCapture.ResumeLayout(false);
            tpVideoCapture.PerformLayout();
            btnVideoCapture.ResumeLayout(false);
            btnVideoCapture.PerformLayout();
            stripVideoCapture.ResumeLayout(false);
            stripVideoCapture.PerformLayout();
            progressBarVideoCapture.ResumeLayout(false);
            progressBarVideoCapture.PerformLayout();
            ((ISupportInitialize)(imageBoxVideoCapture)).EndInit();
            tpImageCapture.ResumeLayout(false);
            tpImageCapture.PerformLayout();
            tpResultPage.ResumeLayout(false);
            tpResultPage.PerformLayout();
            ((ISupportInitialize)(imageBoxResult)).EndInit();
            ResumeLayout(false);
            #endregion

        }

        #region MainWindowElements

        // MainWindow
        private Panel panelMain;
        private StatusStrip menuBar;
        private ToolStripDropDownButton btnWorkMode;
        private ToolStripMenuItem miCameraCapture;
        private ToolStripMenuItem miVideoCapture;
        private ToolStripMenuItem miImageCapture;

        //ClientArea
        private TabControl tabCtrlMain;
        private TabPage tpHomePage;
        private TabPage tpCameraCapture;
        private TabPage tpVideoCapture;
       
        //HomePage   
        //

        //CameraPage
        private Button btnCameraCapture;      
        private StatusStrip stripCameraCapture;
        private ToolStripStatusLabel labelCameraCaptureStatus;
        private ToolStripStatusLabel labelCameraFrameCounter;
        private CheckBox checkBoxRecordCamVideo;
        private Label labelRecordCamVideo;
        private ToolStripStatusLabel labelStopCameraCapture;
        private ImageBox imageBoxCameraCapture;

        //VideoPage
        private Button btnVideoCapture;
        private StatusStrip stripVideoCapture;
        private ToolStripStatusLabel labelVideoCaptureStatus;
        private ToolStripStatusLabel labelVideoFPS;
        private ToolStripStatusLabel labelVideoFrameCounter;
        private ToolStripStatusLabel labelOpenVideoFile;
        private ToolStripStatusLabel labelStopVideoCapture;
        private ProgressBar progressBarVideoCapture;
        private ImageBox imageBoxVideoCapture;

        //ImagePage
        private TabPage tpImageCapture;

        //ResultPage
        private TabPage tpResultPage;
        private ImageBox imageBoxResult;

        #endregion
    }
}