using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HitAndBlow
{
    public partial class PracticeMode : Form
    {
        static int[] AnswerArr = new int[4];
        static Color selectedColor;
        static bool WinFlag;
        GuessTurn[] turns = new GuessTurn[8];

        public class GuessTurn
        {
            /* 멤버 변수 */
            int TurnNum; // 몇번째 판인지

            // 빈칸과 ok버튼 위치
            private int circle_x = 4, circle_y = 2;
            private int ok_x = 200, ok_y = 105;

            // ok버튼 크기와 빈칸의 크기
            private const int ok_Btn_size = 60;
            private const int circles_size = 60;

            Panel Ok_panel; // ok버튼
            Label ok_lbl; // ok 버튼 위에 글자


            Button[] blanksbtn = new Button[4]; // 빈칸

            // 결과 계산 및 출력
            int[] numberarr = new int[4];
            Color[] colorprintarr = new Color[4];

            private TaskCompletionSource<bool> tcs; // ok 기다리기 위한 task

            /* 생성자 함수 */
            public GuessTurn(int num, Form parentform, Panel panel) // 버튼과 빈칸 그리기
            {
                for (int i = 0; i < 4; i++)
                {
                    numberarr[i] = 0;
                    colorprintarr[i] = Color.Gray;
                }

                TurnNum = num;

                Ok_panel = new Panel();
                ok_lbl = new Label();

                // OneToOneMode 폼에 버튼, 라벨 추가하기
                parentform.Controls.Add(Ok_panel);

                ok_lbl.Location = new Point(20, 25);
                ok_lbl.Text = "OK";
                Ok_panel.Controls.Add(ok_lbl);

            }

            /* 버튼 그리기 */
            public void CreateBtns(Panel panel)
            {
                // OK 버튼 그리기
                Ok_panel.Name = String.Format("Ok_panel");
                Ok_panel.Text = String.Format("OK");
                Ok_panel.Enabled = false;
                Ok_panel.Location = new Point(ok_x + 100 * (TurnNum - 1), ok_y);
                Ok_panel.Size = new Size(ok_Btn_size, ok_Btn_size);
                Ok_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                Ok_panel.BackColor = Color.LightGray;


                // 빈칸 그리기
                for (int i = 0; i < 4; i++)
                {
                    blanksbtn[i] = new Button();
                    blanksbtn[i].Name = String.Format("blanksbtn{0}", i + 1);
                    blanksbtn[i].Enabled = false;
                    blanksbtn[i].Location = new Point(circle_x, circle_y + 70 * i);
                    blanksbtn[i].Size = new Size(circles_size, circles_size);
                    blanksbtn[i].Click += BlankBtn_Click; // Click 이벤트 핸들러 등록

                    panel.Controls.Add(blanksbtn[i]);

                    numberarr[i] = 0; // 0로 초기화
                }
            }

            /* 버튼 핸들러, 빈칸 색칠 */
            private void BlankBtn_Click(object sender, EventArgs e)
            {
                // 빈칸 색칠
                ((Button)sender).BackColor = selectedColor;

                // numberarr에 색깔을 숫자로 변환해서 저장
                switch (((Button)sender).Name)
                {
                    case "blanksbtn1":
                        numberarr[0] = ColorToNum(selectedColor);
                        break;
                    case "blanksbtn2":
                        numberarr[1] = ColorToNum(selectedColor);
                        break;
                    case "blanksbtn3":
                        numberarr[2] = ColorToNum(selectedColor);
                        break;
                    case "blanksbtn4":
                        numberarr[3] = ColorToNum(selectedColor);
                        break;
                }
            }

            /* 색깔을 숫자로 변환 */
            private int ColorToNum(Color c)
            {
                if (c == Color.Pink) return 1;
                else if (c == Color.Yellow) return 2;
                else if (c == Color.Green) return 3;
                else if (c == Color.LightGreen) return 4;
                else if (c == Color.Purple) return 5;
                else if (c == Color.Black) return 6;
                else return 0;
            }

            /* 모든 빈칸을 다 채울 때 까지 기다리는 함수 */
            private async Task WaitForOkBtnClickAsync()
            {
                tcs = new TaskCompletionSource<bool>();
                Ok_panel.Click += OkBtn_Click;
                await tcs.Task;
                Ok_panel.Click -= OkBtn_Click;
            }

            /* Ok 버튼 클릭 핸들러 */
            private void OkBtn_Click(object sender, EventArgs e)
            {
                int i;

                for (i = 0; i < 4; i++)
                    if (numberarr[i] == 0)
                        break;

                if (i == 4) // 모든 빈칸이 채워짐
                {
                    tcs.TrySetResult(true);
                    WinFlag = CheckAnswer();
                    ok_lbl.Visible = false;
                    Ok_panel.Paint += OkPanel_Paint; // 판넬에 paint 이벤트 핸들러 등록
                    Ok_panel.Invalidate(); // paint 이벤트 강제 발생
                }
                else
                    MessageBox.Show("빈칸을 모두 채워주세요. ");
            }

            /* Paint 이벤트 핸들러 - 화면에 결과 출력 */
            private void OkPanel_Paint(object sender, PaintEventArgs e)
            {
                Graphics[] g = new Graphics[4];
                for (int i = 0; i < 4; i++) g[i] = e.Graphics;

                // 원 그리기
                Pen[] pens = new Pen[4];
                for (int i = 0; i < 4; i++) pens[i] = new Pen(colorprintarr[i], 2);

                g[0].DrawEllipse(pens[0], new Rectangle(3, 3, 25, 25));
                g[1].DrawEllipse(pens[1], new Rectangle(32, 3, 25, 25));
                g[2].DrawEllipse(pens[2], new Rectangle(3, 32, 25, 25));
                g[3].DrawEllipse(pens[3], new Rectangle(32, 32, 25, 25));

                // 원 색칠하기
                Brush[] brushs = new SolidBrush[4];
                for (int i = 0; i < 4; i++) brushs[i] = new SolidBrush(colorprintarr[i]);
                g[0].FillEllipse(brushs[0], new Rectangle(3, 3, 25, 25));
                g[1].FillEllipse(brushs[1], new Rectangle(32, 3, 25, 25));
                g[2].FillEllipse(brushs[2], new Rectangle(3, 32, 25, 25));
                g[3].FillEllipse(brushs[3], new Rectangle(32, 32, 25, 25));

                // pen이랑 brush 메모리 해제
                for (int i = 0; i < 4; i++)
                {
                    pens[i].Dispose();
                    brushs[i].Dispose();
                }
            }

            /* turn 시작하는 함수 */
            private void StartTurn()
            {
                // static 변수 초기화
                selectedColor = Color.White; // 색깔 선택 초기화

                Ok_panel.Enabled = true;

                for (int i = 0; i < 4; i++)
                    blanksbtn[i].Enabled = true;
            }

            /* turn 끝내는 함수 */
            private void EndTurn()
            {
                Ok_panel.Enabled = false;

                for (int i = 0; i < 4; i++)
                    blanksbtn[i].Enabled = false;

            }

            /* 입력과 정답을 비교하고 출력하는 함수 */
            private bool CheckAnswer()
            {
                int i, j;
                int strike, ball;
                strike = 0; ball = 0;
                bool result = false;

                for (i = 0; i < 4; i++)
                {
                    for (j = 0; j < 4; j++)
                        if (numberarr[j] == AnswerArr[i]) ball += 1;
                    if (numberarr[i] == AnswerArr[i]) strike += 1;
                }

                ball -= strike;

                for (i = 0; i < strike; i++)
                    colorprintarr[i] = Color.Red;
                for (i = strike; i < strike + ball && i < 4; i++)
                    colorprintarr[i] = Color.Blue;

                if (strike == 4) result = true;
                return result;
            }

            public async Task PlayTurn()
            {
                StartTurn();
                await WaitForOkBtnClickAsync();
                EndTurn();
            }
        }

        private void ColorBtn_Click(object sender, EventArgs e)
        {
            if (((Button)sender).BackColor == Color.Pink)
                colorselectionbtn.BackColor = Color.Pink;
            else if (((Button)sender).BackColor == Color.Yellow)
                colorselectionbtn.BackColor = Color.Yellow;
            else if (((Button)sender).BackColor == Color.LightGreen)
                colorselectionbtn.BackColor = Color.LightGreen;
            else if (((Button)sender).BackColor == Color.Green)
                colorselectionbtn.BackColor = Color.Green;
            else if (((Button)sender).BackColor == Color.Purple)
                colorselectionbtn.BackColor = Color.Purple;
            else
                colorselectionbtn.BackColor = Color.Black;

            selectedColor = colorselectionbtn.BackColor;
        }

        /* 랜덤으로 문제 만드는 함수 */
        private void SetRandomNumber()
        {
            Random randomObj = new Random();

            for (int i = 0; i < AnswerArr.GetLength(0); i++)
                AnswerArr[i] = randomObj.Next(1, 6);
        }

        /* 정답 출력하는 함수 */
        private void PrintAnswer()
        {
            // 위치 초기화
            int circle_x = 4, circle_y = 2;
            int circles_size = 60;

            Button[] blanksbtn = new Button[4]; // 빈칸

            // 빈칸 그리기
            for (int i = 0; i < 4; i++)
            {
                blanksbtn[i] = new Button();
                blanksbtn[i].Name = String.Format("blanksbtn{0}", i + 1);
                blanksbtn[i].Enabled = false;
                blanksbtn[i].Location = new Point(circle_x, circle_y + 70 * i);
                blanksbtn[i].Size = new Size(circles_size, circles_size);
                blanksbtn[i].BackColor = NumToColor(AnswerArr[i]);

                answerpanel.Controls.Add(blanksbtn[i]);
            }
        }

        /* 숫자를 색깔로 반환 */
        private Color NumToColor(int n)
        {
            if (n == 1) return Color.Pink;
            else if (n == 2) return Color.Yellow;
            else if (n == 3) return Color.Green;
            else if (n == 4) return Color.LightGreen;
            else if (n == 5) return Color.Purple;
            else if (n == 6) return Color.Black;
            else return Color.White;
        }

        public PracticeMode()
        {
            InitializeComponent();
            SetRandomNumber();
            PrintAnswer(); /////

            // turn 초기화
            turns[0] = new GuessTurn(1, this, playerpanel1);
            turns[0].CreateBtns(playerpanel1);
            turns[1] = new GuessTurn(2, this, playerpanel2);
            turns[1].CreateBtns(playerpanel2);
            turns[2] = new GuessTurn(3, this, playerpanel3);
            turns[2].CreateBtns(playerpanel3);
            turns[3] = new GuessTurn(4, this, playerpanel4);
            turns[3].CreateBtns(playerpanel4);
            turns[4] = new GuessTurn(5, this, playerpanel5);
            turns[4].CreateBtns(playerpanel5);
            turns[5] = new GuessTurn(6, this, playerpanel6);
            turns[5].CreateBtns(playerpanel6);
            turns[6] = new GuessTurn(7, this, playerpanel7);
            turns[6].CreateBtns(playerpanel7);
            turns[7] = new GuessTurn(8, this, playerpanel8);
            turns[7].CreateBtns(playerpanel8);

            // 게임 끝
        }

        private async void PracticeMode_Load(object sender, EventArgs e)
        {
            WinFlag = false;
            for (int i = 0; i < 8; i++)
            {
                await turns[i].PlayTurn();
                if (WinFlag)
                    break;
                colorselectionbtn.BackColor = Color.White;
            }
            GameEnd(WinFlag);
        }

        /* 게임 종료 함수 */
        private void GameEnd(bool result)
        {
            DialogResult d;
            if (result)
                d = MessageBox.Show("Win!\n다시 할까요?", "게임 종료", MessageBoxButtons.YesNo);
            else
                d = MessageBox.Show("Lose!\n다시 할까요?", "게임 종료", MessageBoxButtons.YesNo);

            if (d == DialogResult.Yes) Reset();
            else this.Close(); // 게임 종료, 창 닫기
        }

        /* 게임 재실행을 위한 reset 함수 */
        private void Reset()
        {
            Application.Restart();
        }
    }
}
