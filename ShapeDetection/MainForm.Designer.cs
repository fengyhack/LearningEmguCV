namespace EmguCV.ShapeDetection
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button_LoadImage = new System.Windows.Forms.Button();
            this.button_ToGray = new System.Windows.Forms.Button();
            this.button_HoughLines = new System.Windows.Forms.Button();
            this.button_EdgeDetect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_ThreshLink = new System.Windows.Forms.TextBox();
            this.textBox_Threshold = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_gapBetweenLines = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_lineThreshold = new System.Windows.Forms.TextBox();
            this.textBox_minLineWidth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_rhoResolution = new System.Windows.Forms.TextBox();
            this.textBox_thetaResolution = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(13, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(472, 382);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(510, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(472, 382);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // button_LoadImage
            // 
            this.button_LoadImage.Location = new System.Drawing.Point(564, 446);
            this.button_LoadImage.Name = "button_LoadImage";
            this.button_LoadImage.Size = new System.Drawing.Size(132, 37);
            this.button_LoadImage.TabIndex = 2;
            this.button_LoadImage.Text = "Load Image";
            this.button_LoadImage.UseVisualStyleBackColor = true;
            this.button_LoadImage.Click += new System.EventHandler(this.button_LoadImage_Click);
            // 
            // button_ToGray
            // 
            this.button_ToGray.Location = new System.Drawing.Point(792, 442);
            this.button_ToGray.Name = "button_ToGray";
            this.button_ToGray.Size = new System.Drawing.Size(132, 37);
            this.button_ToGray.TabIndex = 3;
            this.button_ToGray.Text = "Grayscale";
            this.button_ToGray.UseVisualStyleBackColor = true;
            this.button_ToGray.Click += new System.EventHandler(this.button_ToGray_Click);
            // 
            // button_HoughLines
            // 
            this.button_HoughLines.Location = new System.Drawing.Point(792, 560);
            this.button_HoughLines.Name = "button_HoughLines";
            this.button_HoughLines.Size = new System.Drawing.Size(132, 37);
            this.button_HoughLines.TabIndex = 5;
            this.button_HoughLines.Text = "Hough Lines";
            this.button_HoughLines.UseVisualStyleBackColor = true;
            this.button_HoughLines.Click += new System.EventHandler(this.button_HoughLines_Click);
            // 
            // button_EdgeDetect
            // 
            this.button_EdgeDetect.Location = new System.Drawing.Point(564, 560);
            this.button_EdgeDetect.Name = "button_EdgeDetect";
            this.button_EdgeDetect.Size = new System.Drawing.Size(132, 37);
            this.button_EdgeDetect.TabIndex = 4;
            this.button_EdgeDetect.Text = "Canny Edge";
            this.button_EdgeDetect.UseVisualStyleBackColor = true;
            this.button_EdgeDetect.Click += new System.EventHandler(this.button_EdgeDetect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_ThreshLink);
            this.groupBox1.Controls.Add(this.textBox_Threshold);
            this.groupBox1.Location = new System.Drawing.Point(40, 461);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 121);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Canny Parameters";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "thresh_link";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "threshold";
            // 
            // textBox_ThreshLink
            // 
            this.textBox_ThreshLink.Location = new System.Drawing.Point(108, 75);
            this.textBox_ThreshLink.Name = "textBox_ThreshLink";
            this.textBox_ThreshLink.Size = new System.Drawing.Size(65, 25);
            this.textBox_ThreshLink.TabIndex = 1;
            // 
            // textBox_Threshold
            // 
            this.textBox_Threshold.Location = new System.Drawing.Point(108, 31);
            this.textBox_Threshold.Name = "textBox_Threshold";
            this.textBox_Threshold.Size = new System.Drawing.Size(65, 25);
            this.textBox_Threshold.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox_gapBetweenLines);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox_lineThreshold);
            this.groupBox2.Controls.Add(this.textBox_minLineWidth);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox_rhoResolution);
            this.groupBox2.Controls.Add(this.textBox_thetaResolution);
            this.groupBox2.Location = new System.Drawing.Point(237, 430);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 207);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hough Parameters";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(146, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 15);
            this.label13.TabIndex = 14;
            this.label13.Text = "PI/";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "gapBetweenLines";
            // 
            // textBox_gapBetweenLines
            // 
            this.textBox_gapBetweenLines.Location = new System.Drawing.Point(146, 178);
            this.textBox_gapBetweenLines.Name = "textBox_gapBetweenLines";
            this.textBox_gapBetweenLines.Size = new System.Drawing.Size(65, 25);
            this.textBox_gapBetweenLines.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "minLineWidth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "threshold";
            // 
            // textBox_lineThreshold
            // 
            this.textBox_lineThreshold.Location = new System.Drawing.Point(146, 105);
            this.textBox_lineThreshold.Name = "textBox_lineThreshold";
            this.textBox_lineThreshold.Size = new System.Drawing.Size(65, 25);
            this.textBox_lineThreshold.TabIndex = 8;
            // 
            // textBox_minLineWidth
            // 
            this.textBox_minLineWidth.Location = new System.Drawing.Point(146, 142);
            this.textBox_minLineWidth.Name = "textBox_minLineWidth";
            this.textBox_minLineWidth.Size = new System.Drawing.Size(65, 25);
            this.textBox_minLineWidth.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "thetaResolution";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "rhoResolution";
            // 
            // textBox_rhoResolution
            // 
            this.textBox_rhoResolution.Location = new System.Drawing.Point(146, 31);
            this.textBox_rhoResolution.Name = "textBox_rhoResolution";
            this.textBox_rhoResolution.Size = new System.Drawing.Size(65, 25);
            this.textBox_rhoResolution.TabIndex = 4;
            // 
            // textBox_thetaResolution
            // 
            this.textBox_thetaResolution.Location = new System.Drawing.Point(175, 66);
            this.textBox_thetaResolution.Name = "textBox_thetaResolution";
            this.textBox_thetaResolution.Size = new System.Drawing.Size(36, 25);
            this.textBox_thetaResolution.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(525, 457);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "1.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(763, 453);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "2.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(525, 570);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "3.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(763, 571);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 15);
            this.label12.TabIndex = 13;
            this.label12.Text = "4.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(170, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 15);
            this.label11.TabIndex = 14;
            this.label11.Text = "original image";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(705, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 15);
            this.label14.TabIndex = 15;
            this.label14.Text = "result image";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 659);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_HoughLines);
            this.Controls.Add(this.button_EdgeDetect);
            this.Controls.Add(this.button_ToGray);
            this.Controls.Add(this.button_LoadImage);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.Text = "Shape Detection";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button_LoadImage;
        private System.Windows.Forms.Button button_ToGray;
        private System.Windows.Forms.Button button_HoughLines;
        private System.Windows.Forms.Button button_EdgeDetect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_ThreshLink;
        private System.Windows.Forms.TextBox textBox_Threshold;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_gapBetweenLines;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_lineThreshold;
        private System.Windows.Forms.TextBox textBox_minLineWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_rhoResolution;
        private System.Windows.Forms.TextBox textBox_thetaResolution;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
    }
}

