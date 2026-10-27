using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace Memory_Power_Gathering_Game
{
    public partial class Form1 : Form
    {
        
        int memoryPower = 0;
        int timeLeft = 10;
        bool isPlaying = false;

        
        Random rand = new Random();
        List<int> scoreHistory = new List<int>();

        public Form1()
        {
          
            InitializeComponent();

            
            btnStart.Click += new EventHandler(btnStart_Click);
            picTarget.Click += new EventHandler(picTarget_Click);
        }

      
        private void StartGame()
        {
            memoryPower = 0;
            timeLeft = 10;
            isPlaying = true;

            lblScore.Text = "점수: " + memoryPower; 
            lblTime.Text = "시간: 10";

            lblGameOver.Visible = false;
            btnRestart.Visible = false;
            btnStart.Visible = false;
            picTarget.Visible = true;

            timerGame.Enabled = true;
            MoveTarget();
        }

        
        private void btnStart_Click(object sender, EventArgs e)
        {
            StartGame();
        }

     
        private void btnRestart_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        
        private void picTarget_Click(object sender, EventArgs e)
        {
           
            if (isPlaying)
            {
                memoryPower++;
                lblScore.Text = "점수: " + memoryPower;
                MoveTarget();
            }
        }

        
        private void MoveTarget()
        {
           
            int x = rand.Next(0, this.ClientSize.Width - picTarget.Width);
            int y = rand.Next(50, this.ClientSize.Height - picTarget.Height);
            picTarget.Location = new Point(x, y);
        }

        
        private void timerGame_Tick(object sender, EventArgs e)
        {
            lblTime.Text = "시간: " + --timeLeft;

          
            if (timeLeft <= 0)
            {
                timerGame.Stop();
                isPlaying = false;
                picTarget.Visible = false;
                scoreHistory.Add(memoryPower); 

                lblGameOver.Visible = true;
                btnRestart.Visible = true;

                
                if (memoryPower >= 20)
                {
                    lblGameOver.Text = "GAME OVER\n(목표 달성 성공!)";
                    lblGameOver.ForeColor = Color.Blue;
                }
                else
                {
                    lblGameOver.Text = "GAME OVER\n(목표 달성 실패...)";
                    lblGameOver.ForeColor = Color.Red;
                }

                
                int maxScore = 0;
                foreach (int score in scoreHistory)
                {
                    if (score > maxScore)
                    {
                        maxScore = score;
                    }
                }

                lblScore.Text = $"현재 점수: {memoryPower} / 최고 점수: {maxScore}";
            }
        }

      
     
    }
}