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
    public partial class PlayerScreen : UserControl
    {
        public static int pNumber;
        public PlayerScreen()
        {
            InitializeComponent();
        }

        private void player1button_Click(object sender, EventArgs e)
        {
            pNumber = 1;
            PlayerSelected();
        }

        private void player2button_Click(object sender, EventArgs e)
        {
            PlayerSelected();
        }

        private void PlayerSelected()
        {
            LevelScreen ls = new LevelScreen();
            Form form = this.FindForm();

            form.Controls.Add(ls);
            form.Controls.Remove(this);

            ls.Location = new Point((form.Width - ls.Width) / 2, (form.Height - ls.Height) / 2);
        }
    }
}
