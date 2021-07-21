namespace GazelleLowcay_Final_Portfolio.View
{
    partial class BoardGameFrm
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
            this.components = new System.ComponentModel.Container();
            this.LevelName = new System.Windows.Forms.Label();
            this.MoveNumber = new System.Windows.Forms.Label();
            this.maze = new System.Windows.Forms.TableLayoutPanel();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.BtnMoveDown = new System.Windows.Forms.Button();
            this.BtnMoveLeft = new System.Windows.Forms.Button();
            this.BtnMoveRight = new System.Windows.Forms.Button();
            this.BtnWait = new System.Windows.Forms.Button();
            this.BtnMoveUp = new System.Windows.Forms.Button();
            this.GameLevels = new System.Windows.Forms.ComboBox();
            this.LevelChoices = new System.Windows.Forms.Label();
            this.WaitMsg = new System.Windows.Forms.Label();
            this.TimerLapse = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtnStartTimer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnResetTimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LevelName
            // 
            this.LevelName.AutoSize = true;
            this.LevelName.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LevelName.Location = new System.Drawing.Point(13, 13);
            this.LevelName.Name = "LevelName";
            this.LevelName.Size = new System.Drawing.Size(144, 23);
            this.LevelName.TabIndex = 0;
            this.LevelName.Text = "Level Name:";
            // 
            // MoveNumber
            // 
            this.MoveNumber.AutoSize = true;
            this.MoveNumber.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.MoveNumber.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MoveNumber.Location = new System.Drawing.Point(12, 52);
            this.MoveNumber.Name = "MoveNumber";
            this.MoveNumber.Size = new System.Drawing.Size(145, 23);
            this.MoveNumber.TabIndex = 1;
            this.MoveNumber.Text = "Move Count:";
            // 
            // maze
            // 
            this.maze.ColumnCount = 3;
            this.maze.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.09091F));
            this.maze.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.90909F));
            this.maze.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 147F));
            this.maze.Location = new System.Drawing.Point(13, 147);
            this.maze.Name = "maze";
            this.maze.RowCount = 2;
            this.maze.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.01613F));
            this.maze.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.98387F));
            this.maze.Size = new System.Drawing.Size(500, 428);
            this.maze.TabIndex = 2;
            // 
            // BtnMoveDown
            // 
            this.BtnMoveDown.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnMoveDown.BackgroundImage = global::GazelleLowcay_Final_Portfolio.Properties.Resources.down;
            this.BtnMoveDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMoveDown.Location = new System.Drawing.Point(698, 256);
            this.BtnMoveDown.Name = "BtnMoveDown";
            this.BtnMoveDown.Size = new System.Drawing.Size(75, 58);
            this.BtnMoveDown.TabIndex = 4;
            this.BtnMoveDown.UseVisualStyleBackColor = false;
            this.BtnMoveDown.Click += new System.EventHandler(this.BtnMoveDown_Click);
            // 
            // BtnMoveLeft
            // 
            this.BtnMoveLeft.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnMoveLeft.BackgroundImage = global::GazelleLowcay_Final_Portfolio.Properties.Resources.left;
            this.BtnMoveLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMoveLeft.Location = new System.Drawing.Point(617, 201);
            this.BtnMoveLeft.Name = "BtnMoveLeft";
            this.BtnMoveLeft.Size = new System.Drawing.Size(75, 58);
            this.BtnMoveLeft.TabIndex = 5;
            this.BtnMoveLeft.UseVisualStyleBackColor = false;
            this.BtnMoveLeft.Click += new System.EventHandler(this.BtnMoveLeft_Click);
            // 
            // BtnMoveRight
            // 
            this.BtnMoveRight.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnMoveRight.BackgroundImage = global::GazelleLowcay_Final_Portfolio.Properties.Resources.right;
            this.BtnMoveRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMoveRight.Location = new System.Drawing.Point(779, 201);
            this.BtnMoveRight.Name = "BtnMoveRight";
            this.BtnMoveRight.Size = new System.Drawing.Size(75, 58);
            this.BtnMoveRight.TabIndex = 6;
            this.BtnMoveRight.UseVisualStyleBackColor = false;
            this.BtnMoveRight.Click += new System.EventHandler(this.BtnMoveRight_Click);
            // 
            // BtnWait
            // 
            this.BtnWait.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnWait.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnWait.Location = new System.Drawing.Point(617, 371);
            this.BtnWait.Name = "BtnWait";
            this.BtnWait.Size = new System.Drawing.Size(237, 41);
            this.BtnWait.TabIndex = 7;
            this.BtnWait.Text = "WAIT";
            this.BtnWait.UseVisualStyleBackColor = false;
            this.BtnWait.Click += new System.EventHandler(this.BtnWait_Click);
            // 
            // BtnMoveUp
            // 
            this.BtnMoveUp.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnMoveUp.BackgroundImage = global::GazelleLowcay_Final_Portfolio.Properties.Resources.up;
            this.BtnMoveUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnMoveUp.Location = new System.Drawing.Point(698, 147);
            this.BtnMoveUp.Name = "BtnMoveUp";
            this.BtnMoveUp.Size = new System.Drawing.Size(75, 58);
            this.BtnMoveUp.TabIndex = 3;
            this.BtnMoveUp.UseVisualStyleBackColor = false;
            this.BtnMoveUp.Click += new System.EventHandler(this.BtnMoveUp_Click);
            // 
            // GameLevels
            // 
            this.GameLevels.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GameLevels.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameLevels.FormattingEnabled = true;
            this.GameLevels.IntegralHeight = false;
            this.GameLevels.Items.AddRange(new object[] {
            "Level 1",
            "Level 2",
            "Level 3",
            "Level 4",
            "Level 5",
            "---"});
            this.GameLevels.Location = new System.Drawing.Point(617, 48);
            this.GameLevels.Name = "GameLevels";
            this.GameLevels.Size = new System.Drawing.Size(237, 28);
            this.GameLevels.TabIndex = 8;
            this.GameLevels.Text = "Level 1";
            this.GameLevels.SelectedIndexChanged += new System.EventHandler(this.GameLevels_SelectedIndexChanged);
            // 
            // LevelChoices
            // 
            this.LevelChoices.AutoSize = true;
            this.LevelChoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelChoices.Location = new System.Drawing.Point(613, 16);
            this.LevelChoices.Name = "LevelChoices";
            this.LevelChoices.Size = new System.Drawing.Size(117, 20);
            this.LevelChoices.TabIndex = 9;
            this.LevelChoices.Text = "Choose Level";
            // 
            // WaitMsg
            // 
            this.WaitMsg.AutoSize = true;
            this.WaitMsg.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WaitMsg.Location = new System.Drawing.Point(13, 121);
            this.WaitMsg.Name = "WaitMsg";
            this.WaitMsg.Size = new System.Drawing.Size(163, 23);
            this.WaitMsg.TabIndex = 10;
            this.WaitMsg.Text = "Theseus Waiting...";
            this.WaitMsg.Visible = false;
            // 
            // TimerLapse
            // 
            this.TimerLapse.AutoSize = true;
            this.TimerLapse.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerLapse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TimerLapse.Location = new System.Drawing.Point(380, 16);
            this.TimerLapse.Name = "TimerLapse";
            this.TimerLapse.Size = new System.Drawing.Size(110, 23);
            this.TimerLapse.TabIndex = 11;
            this.TimerLapse.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // BtnStartTimer
            // 
            this.BtnStartTimer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnStartTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStartTimer.Location = new System.Drawing.Point(231, 48);
            this.BtnStartTimer.Name = "BtnStartTimer";
            this.BtnStartTimer.Size = new System.Drawing.Size(70, 27);
            this.BtnStartTimer.TabIndex = 13;
            this.BtnStartTimer.Text = "Start Timer";
            this.BtnStartTimer.UseVisualStyleBackColor = false;
            this.BtnStartTimer.Click += new System.EventHandler(this.StartTimer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(227, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Time Lapse: ";
            // 
            // BtnResetTimer
            // 
            this.BtnResetTimer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnResetTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnResetTimer.Location = new System.Drawing.Point(307, 48);
            this.BtnResetTimer.Name = "BtnResetTimer";
            this.BtnResetTimer.Size = new System.Drawing.Size(70, 27);
            this.BtnResetTimer.TabIndex = 15;
            this.BtnResetTimer.Text = "Restart";
            this.BtnResetTimer.UseVisualStyleBackColor = false;
            this.BtnResetTimer.Click += new System.EventHandler(this.BtnResetTimer_Click);
            // 
            // BoardGameFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 645);
            this.Controls.Add(this.BtnResetTimer);
            this.Controls.Add(this.WaitMsg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnStartTimer);
            this.Controls.Add(this.TimerLapse);
            this.Controls.Add(this.LevelChoices);
            this.Controls.Add(this.GameLevels);
            this.Controls.Add(this.BtnWait);
            this.Controls.Add(this.BtnMoveRight);
            this.Controls.Add(this.BtnMoveLeft);
            this.Controls.Add(this.BtnMoveDown);
            this.Controls.Add(this.BtnMoveUp);
            this.Controls.Add(this.maze);
            this.Controls.Add(this.MoveNumber);
            this.Controls.Add(this.LevelName);
            this.Name = "BoardGameFrm";
            this.Text = "Playing Mode";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BoardGameFrm_FormClosed);
            this.Load += new System.EventHandler(this.BoardGameFrm_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BoardGameFrm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LevelName;
        private System.Windows.Forms.Label MoveNumber;
        public System.Windows.Forms.TableLayoutPanel maze;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Button BtnMoveUp;
        private System.Windows.Forms.Button BtnMoveDown;
        private System.Windows.Forms.Button BtnMoveLeft;
        private System.Windows.Forms.Button BtnMoveRight;
        private System.Windows.Forms.Button BtnWait;
        public System.Windows.Forms.ComboBox GameLevels;
        private System.Windows.Forms.Label LevelChoices;
        private System.Windows.Forms.Label WaitMsg;
        private System.Windows.Forms.Label TimerLapse;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BtnStartTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnResetTimer;
    }
}