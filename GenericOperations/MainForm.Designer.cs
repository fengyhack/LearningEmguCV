namespace EmguCV.GenericOperation
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
            this.button_OpenFile = new System.Windows.Forms.Button();
            this.button_SineTrans = new System.Windows.Forms.Button();
            this.button_ToGray = new System.Windows.Forms.Button();
            this.button_SaveAs = new System.Windows.Forms.Button();
            this.button_InvertColor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(10, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(451, 404);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button_OpenFile
            // 
            this.button_OpenFile.Location = new System.Drawing.Point(466, 22);
            this.button_OpenFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_OpenFile.Name = "button_OpenFile";
            this.button_OpenFile.Size = new System.Drawing.Size(76, 29);
            this.button_OpenFile.TabIndex = 1;
            this.button_OpenFile.Text = "Open File";
            this.button_OpenFile.UseVisualStyleBackColor = true;
            this.button_OpenFile.Click += new System.EventHandler(this.button_OpenFile_Click);
            // 
            // button_SineTrans
            // 
            this.button_SineTrans.Location = new System.Drawing.Point(466, 226);
            this.button_SineTrans.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_SineTrans.Name = "button_SineTrans";
            this.button_SineTrans.Size = new System.Drawing.Size(76, 29);
            this.button_SineTrans.TabIndex = 2;
            this.button_SineTrans.Text = "Sine Trans";
            this.button_SineTrans.UseVisualStyleBackColor = true;
            this.button_SineTrans.Click += new System.EventHandler(this.button_SineTrans_Click);
            // 
            // button_ToGray
            // 
            this.button_ToGray.Location = new System.Drawing.Point(465, 161);
            this.button_ToGray.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_ToGray.Name = "button_ToGray";
            this.button_ToGray.Size = new System.Drawing.Size(76, 29);
            this.button_ToGray.TabIndex = 3;
            this.button_ToGray.Text = "Grayscale";
            this.button_ToGray.UseVisualStyleBackColor = true;
            this.button_ToGray.Click += new System.EventHandler(this.button_ToGray_Click);
            // 
            // button_SaveAs
            // 
            this.button_SaveAs.Location = new System.Drawing.Point(467, 294);
            this.button_SaveAs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_SaveAs.Name = "button_SaveAs";
            this.button_SaveAs.Size = new System.Drawing.Size(76, 29);
            this.button_SaveAs.TabIndex = 4;
            this.button_SaveAs.Text = "Save As...";
            this.button_SaveAs.UseVisualStyleBackColor = true;
            this.button_SaveAs.Click += new System.EventHandler(this.button_SaveAs_Click);
            // 
            // button_InvertColor
            // 
            this.button_InvertColor.Location = new System.Drawing.Point(468, 100);
            this.button_InvertColor.Name = "button_InvertColor";
            this.button_InvertColor.Size = new System.Drawing.Size(76, 29);
            this.button_InvertColor.TabIndex = 5;
            this.button_InvertColor.Text = "Invert";
            this.button_InvertColor.UseVisualStyleBackColor = true;
            this.button_InvertColor.Click += new System.EventHandler(this.button_InvertColor_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 435);
            this.Controls.Add(this.button_InvertColor);
            this.Controls.Add(this.button_SaveAs);
            this.Controls.Add(this.button_ToGray);
            this.Controls.Add(this.button_SineTrans);
            this.Controls.Add(this.button_OpenFile);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Generic Operation";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_OpenFile;
        private System.Windows.Forms.Button button_SineTrans;
        private System.Windows.Forms.Button button_ToGray;
        private System.Windows.Forms.Button button_SaveAs;
        private System.Windows.Forms.Button button_InvertColor;
    }
}

