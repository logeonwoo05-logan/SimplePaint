namespace SimplePaint
{


    using System;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Drawing.Imaging;
    using System.Windows.Forms;



    public partial class Form1 : Form
    {

        enum ToolType { Line, Rectangle, Circle } // 사용할 도형 타입
        private Bitmap canvasBitmap;  // 실제 그림이 저장되는 비트맵
        private Graphics canvasGraphics; // 비트맵 위에 그리기 위한 객체
                                                                      
        private bool isDrawing = false; // 현재 드래그 중인지 여부
        private Point startPoint; // 드래그 시작점
        private Point endPoint;    // 드래그 끝점


        private ToolType currentTool = ToolType.Line; // 현재 선택된 도형
        private Color currentColor = Color.Black; // 현재 색상
        private int currentLineWidth = 2; // 현재 선 두께

        private Panel canvasPanel;
        private float zoomFactor = 1.0f;








        public Form1()
        {
            InitializeComponent();

            ResizeToolButtonImage(btnLine);
            ResizeToolButtonImage(btnRectangle);
            ResizeToolButtonImage(btnCircle);

            // 캔버스 패널 초기화 (스크롤바 제공)
            canvasPanel = new Panel();
            canvasPanel.Location = picCanvas.Location;
            canvasPanel.Size = picCanvas.Size;
            canvasPanel.AutoScroll = true;
            canvasPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            this.Controls.Remove(picCanvas);
            picCanvas.Location = new Point(0, 0);
            picCanvas.SizeMode = PictureBoxSizeMode.StretchImage; // 확대 축소를 위해
            canvasPanel.Controls.Add(picCanvas);
            this.Controls.Add(canvasPanel);

            // 캔버스 초기화
            canvasBitmap = new Bitmap(picCanvas.Width, picCanvas.Height);
            canvasGraphics = Graphics.FromImage(canvasBitmap);
            canvasGraphics.Clear(Color.White);

            // 메모리에 그린 흰색 도화지(Bitmap)를 화면의 PictureBox에 연결해주어야 보입니다.
            picCanvas.Image = canvasBitmap;


            // 마우스 이벤트 연결
            picCanvas.MouseDown += PicCanvas_MouseDown;
            picCanvas.MouseMove += PicCanvas_MouseMove;
            picCanvas.MouseUp += PicCanvas_MouseUp;
            picCanvas.MouseWheel += PicCanvas_MouseWheel;

            // picCanvas가 다시 그려질 때 PicCanvas_Paint 함수를 실행하도록 연결
            picCanvas.Paint += PicCanvas_Paint;


            // 도형 선택 버튼 이벤트 연결
            btnLine.Click += btnLine_Click;
            btnRectangle.Click += btnRectangle_Click;
            btnCircle.Click += btnCircle_Click;


            // 색상 콤보박스 이벤트 연결
            cmbColor.Items.Add("Black");
            cmbColor.Items.Add("Red");
            cmbColor.Items.Add("Blue");
            cmbColor.Items.Add("Green");
            cmbColor.SelectedIndexChanged += cmbColor_SelectedIndexChanged;
            cmbColor.SelectedIndex = 0; // 기본값: Black
            
            // 선 두께 트랙바 이벤트 연결
            trbLineWidth.Minimum = 1; // 최소값
            trbLineWidth.Maximum = 10; // 최대값
            trbLineWidth.Value = 5;
            trbLineWidth.ValueChanged += trbLineWidth_ValueChanged;

            // 열기, 저장 버튼 이벤트 연결
            btnOpenFile.Click += btnOpenFile_Click;
            btnSaveFile.Click += btnSaveFile_Click;
        }

        private static void ResizeToolButtonImage(Button button)
        {
            if (button.Image == null)
            {
                return;
            }

            int targetWidth = 68;
            int targetHeight = 68;

            Bitmap scaled = new Bitmap(targetWidth, targetHeight);
            using (Graphics graphics = Graphics.FromImage(scaled))
            {
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(button.Image, 0, 0, targetWidth, targetHeight);
            }

            button.Image = scaled;
            button.ImageAlign = ContentAlignment.TopCenter;
            button.TextAlign = ContentAlignment.BottomCenter;
            button.TextImageRelation = TextImageRelation.ImageAboveText;
            button.Padding = new Padding(4);
        }

        private Point GetImagePoint(Point p)
        {
            return new Point((int)(p.X / zoomFactor), (int)(p.Y / zoomFactor));
        }

        private void PicCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;// 드래그 시작
            startPoint = GetImagePoint(e.Location);  // 시작점 저장

        }

        private void PicCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isDrawing) return;

            endPoint = GetImagePoint(e.Location);

            picCanvas.Invalidate();
        }


        private void PicCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (!isDrawing) return; // 그림 그리기와 상관 없는 마우스 움직임은 무시
            isDrawing = false; endPoint = GetImagePoint(e.Location);
            // 드래그 종료
            // 실제 비트맵에 도형 그리기 (확정)
            using (Pen pen = new Pen(currentColor, currentLineWidth))
            {
                DrawShape(canvasGraphics, pen, startPoint, endPoint);
            }
            picCanvas.Invalidate(); // 다시 그려서 결과 반영, Paint 이벤트 발생
        }

        private void PicCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (!isDrawing) return;
            e.Graphics.ScaleTransform(zoomFactor, zoomFactor); // 확대 비율 반영
            // 점선 펜 (미리보기용)
            using (Pen previewPen = new Pen(currentColor, currentLineWidth))
            {
                previewPen.DashStyle = DashStyle.Dash;
                DrawShape(e.Graphics, previewPen, startPoint, endPoint);
            }
        }

        private void DrawShape(Graphics g, Pen pen, Point p1, Point p2)
        {
            Rectangle rect = GetRectangle(p1, p2);
            switch (currentTool)
            {
                case ToolType.Line:
                    g.DrawLine(pen, p1, p2);
                    break;
                case ToolType.Rectangle:
                    g.DrawRectangle(pen, rect);
                    break;
                case ToolType.Circle:
                    g.DrawEllipse(pen, rect);
                    break;
            }
        }

        private Rectangle GetRectangle(Point p1, Point p2)
        {
            return new Rectangle(
            Math.Min(p1.X, p2.X),
            Math.Min(p1.Y, p2.Y),
            Math.Abs(p1.X - p2.X),
            Math.Abs(p1.Y - p2.Y)
            );
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            currentTool = ToolType.Line;
        }
        private void btnRectangle_Click(object sender, EventArgs e)
        {
            currentTool = ToolType.Rectangle;
        }
        private void btnCircle_Click(object sender, EventArgs e)
        {
            currentTool = ToolType.Circle;
        }

        private void cmbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbColor.SelectedIndex)
            {
                case 0: // Black 검정
                    currentColor = Color.Black;
                    break;
                case 1: // Red 빨강
                    currentColor = Color.Red;
                    break;

                case 2: // Blue 파랑
                    currentColor = Color.Blue;
                    break;
                case 3: // Green 녹색
                    currentColor = Color.Green;
                    break;
                default:
                    currentColor = Color.Black;
                    break;
            }
        }


        private void trbLineWidth_ValueChanged(object sender, EventArgs e)
        {
            currentLineWidth = trbLineWidth.Value;
        }

        private void PicCanvas_MouseWheel(object? sender, MouseEventArgs e)
        {
            if (ModifierKeys.HasFlag(Keys.Control))
            {
                if (e.Delta > 0)
                {
                    zoomFactor *= 1.1f;
                }
                else if (e.Delta < 0)
                {
                    zoomFactor /= 1.1f;
                }

                zoomFactor = Math.Max(0.1f, Math.Min(10.0f, zoomFactor));

                if (canvasBitmap != null)
                {
                    picCanvas.Width = (int)(canvasBitmap.Width * zoomFactor);
                    picCanvas.Height = (int)(canvasBitmap.Height * zoomFactor);
                }

                if (e is HandledMouseEventArgs he)
                {
                    he.Handled = true;
                }
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "이미지 열기";
                openFileDialog.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.bmp|All Files|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Bitmap loadedBitmap = new Bitmap(openFileDialog.FileName);
                        canvasBitmap = new Bitmap(loadedBitmap); // 원본 크기 그대로 사용
                        canvasGraphics = Graphics.FromImage(canvasBitmap);

                        zoomFactor = 1.0f; // 불러올 때 원래 배율로
                        picCanvas.Width = canvasBitmap.Width;
                        picCanvas.Height = canvasBitmap.Height;
                        picCanvas.Image = canvasBitmap;
                        picCanvas.Invalidate();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("이미지를 여는 중 오류가 발생했습니다: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = "이미지 저장";
                saveFileDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";
                saveFileDialog.DefaultExt = "png";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ImageFormat format = ImageFormat.Png;
                        string ext = System.IO.Path.GetExtension(saveFileDialog.FileName).ToLower();
                        switch (ext)
                        {
                            case ".jpg":
                            case ".jpeg":
                                format = ImageFormat.Jpeg;
                                break;
                            case ".bmp":
                                format = ImageFormat.Bmp;
                                break;
                        }

                        canvasBitmap.Save(saveFileDialog.FileName, format);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("이미지를 저장하는 중 오류가 발생했습니다: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }















    }
}
