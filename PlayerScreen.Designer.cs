
namespace BadIceCreamFinal
{
    partial class PlayerScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerScreen));
            this.player2button = new System.Windows.Forms.Button();
            this.player1button = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // player2button
            // 
            this.player2button.BackColor = System.Drawing.Color.SkyBlue;
            this.player2button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("player2button.BackgroundImage")));
            this.player2button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player2button.Font = new System.Drawing.Font("Harrington", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2button.Location = new System.Drawing.Point(451, 176);
            this.player2button.Name = "player2button";
            this.player2button.Size = new System.Drawing.Size(399, 378);
            this.player2button.TabIndex = 19;
            this.player2button.UseVisualStyleBackColor = false;
            this.player2button.Click += new System.EventHandler(this.player2button_Click);
            // 
            // player1button
            // 
            this.player1button.BackColor = System.Drawing.Color.Transparent;
            this.player1button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("player1button.BackgroundImage")));
            this.player1button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player1button.Font = new System.Drawing.Font("Harrington", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1button.Location = new System.Drawing.Point(108, 176);
            this.player1button.Name = "player1button";
            this.player1button.Size = new System.Drawing.Size(344, 378);
            this.player1button.TabIndex = 18;
            this.player1button.UseVisualStyleBackColor = false;
            this.player1button.Click += new System.EventHandler(this.player1button_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Algerian", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(224, 80);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(495, 54);
            this.titleLabel.TabIndex = 17;
            this.titleLabel.Text = "Number of Players";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.player1button);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.player2button);
            this.Name = "PlayerScreen";
            this.Size = new System.Drawing.Size(950, 650);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button player2button;
        private System.Windows.Forms.Button player1button;
        private System.Windows.Forms.Label titleLabel;
    }
}
