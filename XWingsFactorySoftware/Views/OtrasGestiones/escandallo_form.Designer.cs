namespace XWings_MainWindows.OtrasGestiones
{
    partial class escandallo_form
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
            this.custom_treeview1 = new XWings_MainWindows.CustomControls.custom_treeview();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // custom_treeview1
            // 
            this.custom_treeview1.Location = new System.Drawing.Point(12, 12);
            this.custom_treeview1.Name = "custom_treeview1";
            this.custom_treeview1.SelectedItem = null;
            this.custom_treeview1.Size = new System.Drawing.Size(334, 414);
            this.custom_treeview1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(433, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 20);
            this.textBox1.TabIndex = 1;
            // 
            // escandallo_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.custom_treeview1);
            this.Name = "escandallo_form";
            this.Text = "escandallo";
            this.Load += new System.EventHandler(this.escandallo_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.custom_treeview custom_treeview1;
        private System.Windows.Forms.TextBox textBox1;
    }
}