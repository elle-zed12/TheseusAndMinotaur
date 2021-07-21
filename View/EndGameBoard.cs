using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GazelleLowcay_Final_Portfolio.View
{
    public partial class EndGameBoard : Form
    {

        protected BoardGameFrm parent;

        public EndGameBoard(BoardGameFrm theParent)
        {
            InitializeComponent();
            parent = theParent;
            
        } 

        private void BtnRestart_Click(object sender, EventArgs e)
        {
            parent.GameLevels_SelectedIndexChanged(sender, e);
            Close();
            parent.Visible = true;
        }

        private void BtnPreviousLevel_Click(object sender, EventArgs e)
        {
            string currentlevel = parent.GameLevels.Text;
            parent.PreviousLevel(currentlevel);
            Close();
            parent.Visible = true;
        }

        private void BtnNextLevel_Click(object sender, EventArgs e)
        {
            string currentlevel = parent.GameLevels.Text;
            parent.NextLevel(currentlevel);
            Close();
            parent.Visible = true;
        }

        private void BtnExitGame_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void Exit()
        {
            Dispose();
            parent.Dispose();
            this.parent.TheParent.MinotaurImageHolder.Visible = true;
            this.parent.TheParent.TheseusImageHolder.Visible = true;
            this.parent.TheParent.GameTitle.Visible = true;
        }

    }
}
