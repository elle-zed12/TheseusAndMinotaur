using GazelleLowcay_Final_Portfolio.Interface;
using GazelleLowcay_Final_Portfolio.View;
using GazelleLowcay_Final_Portfolio.View.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GazelleLowcay_Final_Portfolio
{
    public partial class MainForm : Form, IView
    {

   
        protected BoardGameFrm board;
        protected Controller controller;       

        public MainForm(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;                     
        }

        private void StartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Start();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Stop();
        }

        public void Pause()
        {
            board.PauseTimerNow();
        }

        public void Start()
        {
            this.TheseusImageHolder.Visible = false;
            this.GameTitle.Visible = false;
            this.MinotaurImageHolder.Visible = false;
            this.board = new BoardGameFrm(controller, this)
            {
                Dock = DockStyle.Fill,
                Anchor = AnchorStyles.Top
            };
            board.MdiParent = this;
            board.Show();
            controller.Go();
            board.SetLevelName(controller.SetLevelName());
            board.MoveCount();
            board.DrawMaze(controller, controller.LevelHeight, controller.LevelWidth);
        }



        public void Stop()
        {
            this.Dispose();
            board.Dispose();
        }

    }
}
