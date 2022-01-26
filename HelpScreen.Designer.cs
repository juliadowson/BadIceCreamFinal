
namespace BadIceCreamFinal
{
    partial class HelpScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Algerian", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Controls";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Algerian", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(570, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "Objective";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LemonChiffon;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Kristen ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(348, 420);
            this.label3.TabIndex = 2;
            this.label3.Text = "Player 1:\r\nUse WASD to move in all directions. \r\n\r\nPlayer 2:\r\nUse the arrow keys " +
    "to move in all directions. \r\n\r\nPause:\r\nPress Space.";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LemonChiffon;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Kristen ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(530, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(348, 420);
            this.label4.TabIndex = 3;
            this.label4.Text = "Collect all the fruit while avoiding enemies to win the level.\r\n\r\nIf it\'s a 2 pla" +
    "yer game, collect the most fruit to win. Also avoid enemies.\r\n\r\nWin levels to un" +
    "lock more.";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.LightBlue;
            this.backButton.FlatAppearance.BorderSize = 3;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Harrington", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(351, 551);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(225, 69);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // HelpScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HelpScreen";
            this.Size = new System.Drawing.Size(950, 650);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button backButton;
    }
}
