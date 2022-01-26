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
    public partial class WinScreen : UserControl
    {
        public WinScreen()
        {
            InitializeComponent();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            //opens next level, if less than or equal to 3
            if (GameScreen.level <= 3)
            {
                GameScreen gs = new GameScreen();
                Form form = this.FindForm();

                form.Controls.Add(gs);
                form.Controls.Remove(this);

                gs.Location = new Point((form.Width - gs.Width) / 2, (form.Height - gs.Height) / 2);
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            //opens menu screen
            MenuScreen ms = new MenuScreen();
            Form form = this.FindForm();

            form.Controls.Add(ms);
            form.Controls.Remove(this);

            ms.Location = new Point((form.Width - ms.Width) / 2, (form.Height - ms.Height) / 2);
        }
    }
}
