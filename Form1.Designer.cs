namespace Memory_Power_Gathering_Game
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.picTarget = new System.Windows.Forms.PictureBox();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picTarget)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("굴림", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStart.Location = new System.Drawing.Point(264, 144);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(255, 96);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "게임 시작";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnRestart
            // 
            this.btnRestart.Font = new System.Drawing.Font("굴림", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRestart.Location = new System.Drawing.Point(264, 263);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(255, 104);
            this.btnRestart.TabIndex = 1;
            this.btnRestart.Text = "다시 시작";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Visible = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // lblGameOver
            // 
            this.lblGameOver.Font = new System.Drawing.Font("굴림", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblGameOver.ForeColor = System.Drawing.Color.Red;
            this.lblGameOver.Location = new System.Drawing.Point(170, 144);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(459, 84);
            this.lblGameOver.TabIndex = 2;
            this.lblGameOver.Text = "GAME OVER";
            this.lblGameOver.Visible = false;
            // 
            // lblScore
            // 
            this.lblScore.Font = new System.Drawing.Font("굴림", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblScore.Location = new System.Drawing.Point(-3, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(800, 61);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "점수: 0";
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTime.Location = new System.Drawing.Point(12, 61);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(164, 32);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "시간：１０";
            // 
            // picTarget
            // 
            this.picTarget.Image = global::Memory_Power_Gathering_Game.Properties.Resources.ChatGPT_Image_2026년_6월_22일_오후_02_36_51;
            this.picTarget.Location = new System.Drawing.Point(255, 304);
            this.picTarget.Name = "picTarget";
            this.picTarget.Size = new System.Drawing.Size(85, 63);
            this.picTarget.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTarget.TabIndex = 5;
            this.picTarget.TabStop = false;
            this.picTarget.Visible = false;
            // 
            // timerGame
            // 
            this.timerGame.Interval = 1000;
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picTarget);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picTarget)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.PictureBox picTarget;
        private System.Windows.Forms.Timer timerGame;
    }
}

