namespace SimplePaint
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

            ResizeToolButtonImage(btnLine);
            ResizeToolButtonImage(btnRectangle);
            ResizeToolButtonImage(btnCircle);
        }

        private static void ResizeToolButtonImage(Button button)
        {
            if (button.Image == null)
            {
                return;
            }

            // 버튼의 크기(140x135)에 맞춰 텍스트를 방해하지 않는 선에서 이미지를 100x100으로 강제 확대합니다.
            int targetWidth = 100;
            int targetHeight = 100;

            Bitmap scaled = new Bitmap(targetWidth, targetHeight);
            using (Graphics graphics = Graphics.FromImage(scaled))
            {
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                // 기존 비율과 상관없이 정확히 100x100 사이즈로 꽉 채워서 그립니다.
                graphics.DrawImage(button.Image, 0, 0, targetWidth, targetHeight);
            }

            button.Image = scaled;
            // 텍스트와 이미지가 겹치지 않도록 위/아래로 분리배치
            button.ImageAlign = ContentAlignment.TopCenter;
            button.TextAlign = ContentAlignment.BottomCenter;
            button.TextImageRelation = TextImageRelation.ImageAboveText;
            button.Padding = new Padding(4);
        }

        private void btnLine_Click(object sender, EventArgs e)
        {

        }
    }
}
