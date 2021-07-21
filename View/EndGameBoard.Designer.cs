namespace GazelleLowcay_Final_Portfolio.View
{
    partial class EndGameBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MsgWhoWin = new System.Windows.Forms.Label();
            this.BtnNextLevel = new System.Windows.Forms.Button();
            this.BtnRestart = new System.Windows.Forms.Button();
            this.BtnPreviousLevel = new System.Windows.Forms.Button();
            this.BtnExitGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MsgWhoWin
            // 
            this.MsgWhoWin.AutoSize = true;
            this.MsgWhoWin.Font = new System.Drawing.Font("Snap ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgWhoWin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.MsgWhoWin.Location = new System.Drawing.Point(222, 150);
            this.MsgWhoWin.Name = "MsgWhoWin";
            this.MsgWhoWin.Size = new System.Drawing.Size(418, 37);
            this.MsgWhoWin.TabIndex = 0;
            this.MsgWhoWin.Text = "Message for the Winner";
            // 
            // BtnNextLevel
            // 
            this.BtnNextLevel.AutoSize = true;
            this.BtnNextLevel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BtnNextLevel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNextLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnNextLevel.Location = new System.Drawing.Point(332, 349);
            this.BtnNextLevel.Name = "BtnNextLevel";
            this.BtnNextLevel.Size = new System.Drawing.Size(217, 47);
            this.BtnNextLevel.TabIndex = 1;
            this.BtnNextLevel.Text = "NEXT LEVEL";
            this.BtnNextLevel.UseVisualStyleBackColor = false;
            this.BtnNextLevel.Click += new System.EventHandler(this.BtnNextLevel_Click);
            // 
            // BtnRestart
            // 
            this.BtnRestart.AutoSize = true;
            this.BtnRestart.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BtnRestart.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRestart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnRestart.Location = new System.Drawing.Point(332, 220);
            this.BtnRestart.Name = "BtnRestart";
            this.BtnRestart.Size = new System.Drawing.Size(217, 47);
            this.BtnRestart.TabIndex = 2;
            this.BtnRestart.Text = "PLAY THIS LEVEL AGAIN";
            this.BtnRestart.UseVisualStyleBackColor = false;
            this.BtnRestart.Click += new System.EventHandler(this.BtnRestart_Click);
            // 
            // BtnPreviousLevel
            // 
            this.BtnPreviousLevel.AutoSize = true;
            this.BtnPreviousLevel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BtnPreviousLevel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPreviousLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnPreviousLevel.Location = new System.Drawing.Point(332, 287);
            this.BtnPreviousLevel.Name = "BtnPreviousLevel";
            this.BtnPreviousLevel.Size = new System.Drawing.Size(217, 47);
            this.BtnPreviousLevel.TabIndex = 3;
            this.BtnPreviousLevel.Text = "PREVIOUS LEVEL";
            this.BtnPreviousLevel.UseVisualStyleBackColor = false;
            this.BtnPreviousLevel.Click += new System.EventHandler(this.BtnPreviousLevel_Click);
            // 
            // BtnExitGame
            // 
            this.BtnExitGame.AutoSize = true;
            this.BtnExitGame.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BtnExitGame.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExitGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnExitGame.Location = new System.Drawing.Point(332, 414);
            this.BtnExitGame.Name = "BtnExitGame";
            this.BtnExitGame.Size = new System.Drawing.Size(217, 47);
            this.BtnExitGame.TabIndex = 4;
            this.BtnExitGame.Text = "EXIT GAME";
            this.BtnExitGame.UseVisualStyleBackColor = false;
            this.BtnExitGame.Click += new System.EventHandler(this.BtnExitGame_Click);
            // 
            // EndGameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 645);
            this.Controls.Add(this.BtnExitGame);
            this.Controls.Add(this.BtnPreviousLevel);
            this.Controls.Add(this.BtnRestart);
            this.Controls.Add(this.BtnNextLevel);
            this.Controls.Add(this.MsgWhoWin);
            this.Name = "EndGameBoard";
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label MsgWhoWin;
        private System.Windows.Forms.Button BtnNextLevel;
        private System.Windows.Forms.Button BtnRestart;
        private System.Windows.Forms.Button BtnPreviousLevel;
        private System.Windows.Forms.Button BtnExitGame;
    }
}