
namespace BadIceCreamFinal
{
    partial class MenuScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuScreen));
            this.titleLabel = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Algerian", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(203, 74);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(548, 78);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "BAD ICE CREAM";
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.LightPink;
            this.playButton.FlatAppearance.BorderSize = 3;
            this.playButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Harrington", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.playButton.Location = new System.Drawing.Point(192, 217);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(578, 89);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.helpButton.FlatAppearance.BorderSize = 3;
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpButton.Font = new System.Drawing.Font("Harrington", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpButton.Location = new System.Drawing.Point(192, 329);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(578, 89);
            this.helpButton.TabIndex = 3;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Tan;
            this.exitButton.FlatAppearance.BorderSize = 3;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Harrington", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exitButton.Location = new System.Drawing.Point(192, 448);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(578, 89);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.titleLabel);
            this.Name = "MenuScreen";
            this.Size = new System.Drawing.Size(950, 650);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button exitButton;
    }
}
