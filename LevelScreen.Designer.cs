
namespace BadIceCreamFinal
{
    partial class LevelScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LevelScreen));
            this.level3button = new System.Windows.Forms.Button();
            this.level2button = new System.Windows.Forms.Button();
            this.level1button = new System.Windows.Forms.Button();
            this.title2Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // level3button
            // 
            this.level3button.BackColor = System.Drawing.Color.SkyBlue;
            this.level3button.Font = new System.Drawing.Font("Harrington", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level3button.Location = new System.Drawing.Point(600, 245);
            this.level3button.Name = "level3button";
            this.level3button.Size = new System.Drawing.Size(222, 110);
            this.level3button.TabIndex = 9;
            this.level3button.Text = "Level 3";
            this.level3button.UseVisualStyleBackColor = false;
            this.level3button.Click += new System.EventHandler(this.level3button_Click);
            // 
            // level2button
            // 
            this.level2button.BackColor = System.Drawing.Color.SkyBlue;
            this.level2button.Font = new System.Drawing.Font("Harrington", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level2button.Location = new System.Drawing.Point(365, 245);
            this.level2button.Name = "level2button";
            this.level2button.Size = new System.Drawing.Size(222, 110);
            this.level2button.TabIndex = 8;
            this.level2button.Text = "Level 2";
            this.level2button.UseVisualStyleBackColor = false;
            this.level2button.Click += new System.EventHandler(this.level2button_Click);
            // 
            // level1button
            // 
            this.level1button.BackColor = System.Drawing.Color.SkyBlue;
            this.level1button.Font = new System.Drawing.Font("Harrington", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level1button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.level1button.Location = new System.Drawing.Point(130, 245);
            this.level1button.Name = "level1button";
            this.level1button.Size = new System.Drawing.Size(222, 110);
            this.level1button.TabIndex = 7;
            this.level1button.Text = "Level 1";
            this.level1button.UseVisualStyleBackColor = false;
            this.level1button.Click += new System.EventHandler(this.level1button_Click);
            // 
            // title2Label
            // 
            this.title2Label.AutoSize = true;
            this.title2Label.BackColor = System.Drawing.Color.Transparent;
            this.title2Label.Font = new System.Drawing.Font("Algerian", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title2Label.Location = new System.Drawing.Point(310, 75);
            this.title2Label.Name = "title2Label";
            this.title2Label.Size = new System.Drawing.Size(346, 54);
            this.title2Label.TabIndex = 14;
            this.title2Label.Text = "Level Select";
            this.title2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LevelScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.title2Label);
            this.Controls.Add(this.level3button);
            this.Controls.Add(this.level2button);
            this.Controls.Add(this.level1button);
            this.Name = "LevelScreen";
            this.Size = new System.Drawing.Size(950, 650);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button level3button;
        private System.Windows.Forms.Button level2button;
        private System.Windows.Forms.Button level1button;
        private System.Windows.Forms.Label title2Label;
    }
}
