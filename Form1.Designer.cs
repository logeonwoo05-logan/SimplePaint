namespace SimplePaint
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblAppName = new Label();
            grbSelect = new GroupBox();
            btnCircle = new Button();
            btnRectangle = new Button();
            btnLine = new Button();
            grbColor = new GroupBox();
            cmbColor = new ComboBox();
            groupBox3 = new GroupBox();
            trbLineWidth = new TrackBar();
            btnOpenFile = new Button();
            btnSaveFile = new Button();
            pictureBox1 = new PictureBox();
            grbSelect.SuspendLayout();
            grbColor.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trbLineWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("맑은 고딕", 30F, FontStyle.Bold);
            lblAppName.ForeColor = Color.Blue;
            lblAppName.Location = new Point(0, 0);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(524, 106);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Simple Paint";
            // 
            // grbSelect
            // 
            grbSelect.Controls.Add(btnCircle);
            grbSelect.Controls.Add(btnRectangle);
            grbSelect.Controls.Add(btnLine);
            grbSelect.Location = new Point(12, 176);
            grbSelect.Name = "grbSelect";
            grbSelect.Size = new Size(472, 200);
            grbSelect.TabIndex = 1;
            grbSelect.TabStop = false;
            grbSelect.Text = "도형 선택";
            // 
            // btnCircle
            // 
            btnCircle.Image = (Image)resources.GetObject("btnCircle.Image");
            btnCircle.ImageAlign = ContentAlignment.TopCenter;
            btnCircle.Location = new Point(326, 59);
            btnCircle.Name = "btnCircle";
            btnCircle.Size = new Size(140, 135);
            btnCircle.TabIndex = 2;
            btnCircle.Text = "원";
            btnCircle.TextAlign = ContentAlignment.BottomCenter;
            btnCircle.UseVisualStyleBackColor = true;
            // 
            // btnRectangle
            // 
            btnRectangle.Image = (Image)resources.GetObject("btnRectangle.Image");
            btnRectangle.ImageAlign = ContentAlignment.TopCenter;
            btnRectangle.Location = new Point(166, 57);
            btnRectangle.Name = "btnRectangle";
            btnRectangle.Size = new Size(140, 135);
            btnRectangle.TabIndex = 1;
            btnRectangle.Text = "사각형";
            btnRectangle.TextAlign = ContentAlignment.BottomCenter;
            btnRectangle.UseVisualStyleBackColor = true;
            // 
            // btnLine
            // 
            btnLine.Font = new Font("맑은 고딕", 11F);
            btnLine.Image = (Image)resources.GetObject("btnLine.Image");
            btnLine.ImageAlign = ContentAlignment.TopCenter;
            btnLine.Location = new Point(6, 57);
            btnLine.Name = "btnLine";
            btnLine.Size = new Size(140, 135);
            btnLine.TabIndex = 0;
            btnLine.Text = "직선";
            btnLine.TextAlign = ContentAlignment.BottomCenter;
            btnLine.UseVisualStyleBackColor = true;
            btnLine.Click += btnLine_Click;
            // 
            // grbColor
            // 
            grbColor.Controls.Add(cmbColor);
            grbColor.Location = new Point(496, 176);
            grbColor.Name = "grbColor";
            grbColor.Size = new Size(239, 200);
            grbColor.TabIndex = 2;
            grbColor.TabStop = false;
            grbColor.Text = "색 선택";
            // 
            // cmbColor
            // 
            cmbColor.FormattingEnabled = true;
            cmbColor.Location = new Point(6, 96);
            cmbColor.Name = "cmbColor";
            cmbColor.Size = new Size(214, 40);
            cmbColor.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(trbLineWidth);
            groupBox3.Location = new Point(741, 176);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(330, 200);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "선 두께";
            // 
            // trbLineWidth
            // 
            trbLineWidth.Location = new Point(32, 83);
            trbLineWidth.Name = "trbLineWidth";
            trbLineWidth.Size = new Size(268, 90);
            trbLineWidth.TabIndex = 0;
            // 
            // btnOpenFile
            // 
            btnOpenFile.BackColor = Color.FromArgb(255, 255, 192);
            btnOpenFile.Font = new Font("Microsoft Sans Serif", 15F);
            btnOpenFile.Location = new Point(1097, 243);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(142, 106);
            btnOpenFile.TabIndex = 0;
            btnOpenFile.Text = "열기";
            btnOpenFile.UseVisualStyleBackColor = false;
            // 
            // btnSaveFile
            // 
            btnSaveFile.BackColor = Color.FromArgb(192, 255, 255);
            btnSaveFile.Font = new Font("Microsoft Sans Serif", 15F);
            btnSaveFile.Location = new Point(1257, 245);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(142, 106);
            btnSaveFile.TabIndex = 3;
            btnSaveFile.Text = "저장";
            btnSaveFile.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(18, 406);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1381, 732);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1424, 1168);
            Controls.Add(pictureBox1);
            Controls.Add(btnSaveFile);
            Controls.Add(btnOpenFile);
            Controls.Add(groupBox3);
            Controls.Add(grbColor);
            Controls.Add(grbSelect);
            Controls.Add(lblAppName);
            Name = "Form1";
            Text = "Simple Paint v1.0";
            grbSelect.ResumeLayout(false);
            grbColor.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trbLineWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private GroupBox grbSelect;
        private GroupBox grbColor;
        private GroupBox groupBox3;
        private Button btnOpenFile;
        private Button btnLine;
        private Button btnSaveFile;
        private Button btnCircle;
        private Button btnRectangle;
        private ComboBox cmbColor;
        private TrackBar trbLineWidth;
        private PictureBox pictureBox1;
    }
}
