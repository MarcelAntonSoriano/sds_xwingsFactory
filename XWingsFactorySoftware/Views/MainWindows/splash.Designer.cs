namespace XWingsFactorySoftware
{
    partial class splash
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.spinningCircles1 = new AltoControls.SpinningCircles();
            this.SuspendLayout();
            // 
            // spinningCircles1
            // 
            this.spinningCircles1.BackColor = System.Drawing.Color.Transparent;
            this.spinningCircles1.FullTransparent = true;
            this.spinningCircles1.Increment = 1F;
            this.spinningCircles1.Location = new System.Drawing.Point(347, 326);
            this.spinningCircles1.N = 8;
            this.spinningCircles1.Name = "spinningCircles1";
            this.spinningCircles1.Radius = 2.5F;
            this.spinningCircles1.Size = new System.Drawing.Size(90, 100);
            this.spinningCircles1.TabIndex = 1;
            this.spinningCircles1.Text = "spinningCircles1";
            // 
            // splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 425);
            this.Controls.Add(this.spinningCircles1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "splash";
            this.Text = "splash";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private AltoControls.SpinningCircles spinningCircles1;
    }
}