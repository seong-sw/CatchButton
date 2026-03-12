namespace CatchButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void movingButton_Click(object sender, EventArgs e)
        {

        }

        private void movingButton_MouseEnter(object sender, EventArgs e)
        {
            // sender 객체를 변수로 정의
            var button = (Button)sender;

            // 신규 Random 객체 선언
            Random random = new Random();

            // x, y 변수를 랜덤으로 생성 (버튼이 창 밖으로 나가지 않도록 최대치를 button의 크기만큼 줄임)
            int x = random.Next(0, this.ClientSize.Width - button.Width);
            int y = random.Next(0, this.ClientSize.Height - button.Height);

            // button의 위치를 x, y로 이동
            button.Location = new Point(x, y);

            //Form title에 button의 좌표를 표시
            this.Text = $"Button Location: ({x}, {y})";
        }
    }
}
