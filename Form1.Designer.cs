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
            grbLineWidth = new GroupBox();
            trbLineWidth = new TrackBar();
            btnOpenFile = new Button();
            btnSaveFile = new Button();
            picCanvas = new PictureBox();
            grbSelect.SuspendLayout();
            grbColor.SuspendLayout();
            grbLineWidth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trbLineWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCanvas).BeginInit();
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
            btnCircle.Font = new Font("맑은 고딕", 11F);
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
            btnRectangle.Font = new Font("맑은 고딕", 11F);
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
            // grbLineWidth
            // 
            grbLineWidth.Controls.Add(trbLineWidth);
            grbLineWidth.Location = new Point(741, 176);
            grbLineWidth.Name = "grbLineWidth";
            grbLineWidth.Size = new Size(330, 200);
            grbLineWidth.TabIndex = 2;
            grbLineWidth.TabStop = false;
            grbLineWidth.Text = "선 두께";
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
            // picCanvas
            // 
            picCanvas.BorderStyle = BorderStyle.FixedSingle;
            picCanvas.Location = new Point(18, 406);
            picCanvas.Name = "picCanvas";
            picCanvas.Size = new Size(1381, 732);
            picCanvas.TabIndex = 4;
            picCanvas.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1424, 1168);
            Controls.Add(picCanvas);
            Controls.Add(btnSaveFile);
            Controls.Add(btnOpenFile);
            Controls.Add(grbLineWidth);
            Controls.Add(grbColor);
            Controls.Add(grbSelect);
            Controls.Add(lblAppName);
            Name = "Form1";
            Text = "Simple Paint v1.0";
            grbSelect.ResumeLayout(false);
            grbColor.ResumeLayout(false);
            grbLineWidth.ResumeLayout(false);
            grbLineWidth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trbLineWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCanvas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private GroupBox grbSelect;
        private GroupBox grbColor;
        private GroupBox grbLineWidth;
        private Button btnOpenFile;
        private Button btnLine;
        private Button btnSaveFile;
        private Button btnCircle;
        private Button btnRectangle;
        private ComboBox cmbColor;
        private TrackBar trbLineWidth;
        private PictureBox picCanvas;
    }
}
