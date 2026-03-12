namespace CatchButton
{
    public partial class Form1 : Form
    {
        int score = 1000; // 점수 초기 선언
        int miss = 0; // 놓친 횟수 초기 선언

        public Form1()
        {
            InitializeComponent();
        }

        private void movingButton_MouseEnter(object sender, EventArgs e)
        {
            // sender 객체를 변수로 정의
            var button = (Button)sender;

            // 버튼이 움직일 때마다 점수를 10 씩 감소
            score -= 10;

            // 놓친 횟수를 1 증가
            miss += 1;

            // 놓친 횟수가 20회를 초과하면 게임 오버 메시지 출력 및 버튼 비활성화
            if (miss > 20)
            {
                button.Enabled = false;
                MessageBox.Show("게임 오버!");
            }
            else // 예외 처리
            {

                // 신규 Random 객체 선언
                Random random = new Random();

                // x, y 변수를 랜덤으로 생성 (버튼이 창 밖으로 나가지 않도록 최대치를 button의 크기만큼 줄임)
                int x = random.Next(0, this.ClientSize.Width - button.Width);
                int y = random.Next(0, this.ClientSize.Height - button.Height);

                // button의 위치를 x, y로 이동
                button.Location = new Point(x, y);

                //Form title에 button의 좌표를 표시
                this.Text = $"Button Location: ({x}, {y}), Score: {score}";

                // 효과음 출력
                System.Media.SystemSounds.Hand.Play();
            }
        }

        private void movingButton_MouseClick(object sender, MouseEventArgs e)
        {
            // 버튼에 클릭을 감지하여 축하 메시지 및 효과음 출력
            if (e.Button == MouseButtons.Left)
            {
                // sender 객체를 변수로 정의
                var button = (Button)sender;

                // 버튼을 클릭하면 점수를 100 씩 증가
                score += 100;

                // Form title에 button의 좌표를 표시
                this.Text = $"Button Location: ({button.Location.X}, {button.Location.Y}), Score: {score}";

                // 버튼의 크기를 90%로 축소 (각 클릭마다 90%로 줄임)
                var newWidth = Math.Max(1, (int)(button.Width * 0.9));
                var newHeight = Math.Max(1, (int)(button.Height * 0.9));
                button.Size = new Size(newWidth, newHeight);

                MessageBox.Show("축하합니다!");
                System.Media.SystemSounds.Beep.Play();
            }
        }

        private void restartButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var button = (Button)sender;
                score = 1000; // 점수 초기화
                miss = 0; // 놓친 횟수 초기화
                movingButton.Enabled = true; // 버튼 활성화
                // Form title 초기화
                this.Text = $"Button Location: ({button.Location.X}, {button.Location.Y}), Score: 1000";
            }
        }
    }
}
