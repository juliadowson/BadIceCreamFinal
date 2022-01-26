using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadIceCreamFinal
{
    public partial class MenuScreen : UserControl
    {
     
        public static string players = "";

        public MenuScreen()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            HelpScreen hs = new HelpScreen();
            Form form = this.FindForm();

            form.Controls.Add(hs);
            form.Controls.Remove(this);

            hs.Location = new Point((form.Width - hs.Width) / 2, (form.Height - hs.Height) / 2);
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            PlayerScreen ps = new PlayerScreen();
            Form form = this.FindForm();

            form.Controls.Add(ps);
            form.Controls.Remove(this);

            ps.Location = new Point((form.Width - ps.Width) / 2, (form.Height - ps.Height) / 2);
        }
    }
}
