using GazelleLowcay_Final_Portfolio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GazelleLowcay_Final_Portfolio
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Game game = new Game();
            Controller controller = new Controller(game);
            Application.Run(new MainForm(controller));
        }
    }
}
