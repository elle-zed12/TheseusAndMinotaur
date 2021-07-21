namespace GazelleLowcay_Final_Portfolio
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.TheseusImageHolder = new System.Windows.Forms.Panel();
            this.MinotaurImageHolder = new System.Windows.Forms.Panel();
            this.GameTitle = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(919, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.StartToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // TheseusImageHolder
            // 
            this.TheseusImageHolder.BackgroundImage = global::GazelleLowcay_Final_Portfolio.Properties.Resources.theseus;
            this.TheseusImageHolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TheseusImageHolder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TheseusImageHolder.Location = new System.Drawing.Point(249, 231);
            this.TheseusImageHolder.Name = "TheseusImageHolder";
            this.TheseusImageHolder.Size = new System.Drawing.Size(200, 183);
            this.TheseusImageHolder.TabIndex = 3;
            // 
            // MinotaurImageHolder
            // 
            this.MinotaurImageHolder.BackgroundImage = global::GazelleLowcay_Final_Portfolio.Properties.Resources.minotaur;
            this.MinotaurImageHolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinotaurImageHolder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MinotaurImageHolder.Location = new System.Drawing.Point(455, 231);
            this.MinotaurImageHolder.Name = "MinotaurImageHolder";
            this.MinotaurImageHolder.Size = new System.Drawing.Size(200, 183);
            this.MinotaurImageHolder.TabIndex = 4;
            // 
            // GameTitle
            // 
            this.GameTitle.AutoSize = true;
            this.GameTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GameTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GameTitle.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameTitle.Location = new System.Drawing.Point(338, 210);
            this.GameTitle.Name = "GameTitle";
            this.GameTitle.Size = new System.Drawing.Size(246, 29);
            this.GameTitle.TabIndex = 5;
            this.GameTitle.Text = "Theseus VS Minotaur";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(919, 717);
            this.Controls.Add(this.GameTitle);
            this.Controls.Add(this.MinotaurImageHolder);
            this.Controls.Add(this.TheseusImageHolder);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Thesues Vs Minotaur";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        public System.Windows.Forms.Panel TheseusImageHolder;
        public System.Windows.Forms.Panel MinotaurImageHolder;
        public System.Windows.Forms.Label GameTitle;
    }
}

