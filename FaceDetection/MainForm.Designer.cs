namespace EmguCV.FaceDetection
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_OpenCamera = new System.Windows.Forms.Button();
            this.button_OpenVideo = new System.Windows.Forms.Button();
            this.button_StopCapture = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(562, 399);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button_OpenCamera
            // 
            this.button_OpenCamera.Location = new System.Drawing.Point(573, 27);
            this.button_OpenCamera.Name = "button_OpenCamera";
            this.button_OpenCamera.Size = new System.Drawing.Size(75, 34);
            this.button_OpenCamera.TabIndex = 1;
            this.button_OpenCamera.Text = "Camera";
            this.button_OpenCamera.UseVisualStyleBackColor = true;
            this.button_OpenCamera.Click += new System.EventHandler(this.button_OpenCamera_Click);
            // 
            // button_OpenVideo
            // 
            this.button_OpenVideo.Location = new System.Drawing.Point(573, 132);
            this.button_OpenVideo.Name = "button_OpenVideo";
            this.button_OpenVideo.Size = new System.Drawing.Size(75, 34);
            this.button_OpenVideo.TabIndex = 2;
            this.button_OpenVideo.Text = "Video";
            this.button_OpenVideo.UseVisualStyleBackColor = true;
            this.button_OpenVideo.Click += new System.EventHandler(this.button_OpenVideo_Click);
            // 
            // button_StopCapture
            // 
            this.button_StopCapture.Location = new System.Drawing.Point(573, 225);
            this.button_StopCapture.Name = "button_StopCapture";
            this.button_StopCapture.Size = new System.Drawing.Size(75, 34);
            this.button_StopCapture.TabIndex = 4;
            this.button_StopCapture.Text = "Stop";
            this.button_StopCapture.UseVisualStyleBackColor = true;
            this.button_StopCapture.Click += new System.EventHandler(this.button_StopCapture_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 407);
            this.Controls.Add(this.button_StopCapture);
            this.Controls.Add(this.button_OpenVideo);
            this.Controls.Add(this.button_OpenCamera);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.Text = "Face Detection";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_OpenCamera;
        private System.Windows.Forms.Button button_OpenVideo;
        private System.Windows.Forms.Button button_StopCapture;
    }
}

