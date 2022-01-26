﻿using System;
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
    public partial class LevelScreen : UserControl
    {
        List<Button> buttons;
        public LevelScreen()
        {
            InitializeComponent();
            buttons = new List<Button>() { level1button, level2button, level3button };
            OnStart();
        }

        private void OnStart()
        {
            for (int i = 0; i < buttons.Count; i++)
            {
                //blocks levels 
                buttons[i].Enabled = false;
            }

            for (int i = 0; i < GameScreen.levelUnlock; i++)
            {
                //'unlocks' levels 
                buttons[i].Enabled = true;
            }
        }

        private void level1button_Click(object sender, EventArgs e)
        {
            GameScreen.level = 1;
            OpenGameScreen();
            //opens level 1
        }

        private void level2button_Click(object sender, EventArgs e)
        {
            GameScreen.level = 2;
            OpenGameScreen();
            //opens level 2
        }

        private void level3button_Click(object sender, EventArgs e)
        {
            GameScreen.level = 3;
            OpenGameScreen();
            //opens level 3
        }

        private void OpenGameScreen()
        {
            //opens GameScreen
            GameScreen gs = new GameScreen();
            Form form = this.FindForm();

            form.Controls.Add(gs);
            form.Controls.Remove(this);

            gs.Location = new Point((form.Width - gs.Width) / 2, (form.Height - gs.Height) / 2);
        }
    }
}
