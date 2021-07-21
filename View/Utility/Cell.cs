using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GazelleLowcay_Final_Portfolio.View.Utility
{
    public sealed class Cell: Form
    {        
        public Label Line;
        private const int thickness = 5;
        private const int lenght = 100;

        public Label DrawTop() 
        {
            Line = new Label
            {
                Anchor = AnchorStyles.Top,
                BackColor = Color.Black,
                Dock = DockStyle.Top,
                AutoSize = false,
                Height = thickness,
                Width = lenght,
                Text = ""
            };

            return Line;

        }

        public Label DrawBottom() 
        {
            Line = new Label
            {
                Anchor = AnchorStyles.Bottom,
                Dock = DockStyle.Bottom,
                BackColor = Color.Black,
                AutoSize = false,
                Height = thickness,
                Width = lenght,
                Text = ""
            };
            return Line;
        }

        public Label DrawRight() {
            Line = new Label
            {
                Anchor = AnchorStyles.Right,
                BackColor = Color.Black,
                Dock = DockStyle.Right,
                AutoSize = false,
                Height = lenght,
                Width = thickness,
                Text = ""
            };
            return Line;
        }

        public Label DrawLeft() 
        {
            Line = new Label
            {
                Anchor = AnchorStyles.Left,
                BackColor = Color.Black,
                Dock = DockStyle.Left,
                AutoSize = false,
                Height = lenght,
                Width = thickness,
                Text = ""
            };
            return Line;
        }
    }
}
