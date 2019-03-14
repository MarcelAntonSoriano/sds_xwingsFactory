namespace XWings_MainWindows.Views.Mantenimiento
{
    partial class AccessLevel
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
            this.DataGrid_AccessLevel = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_AccessLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid_AccessLevel
            // 
            this.DataGrid_AccessLevel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_AccessLevel.Location = new System.Drawing.Point(25, 138);
            this.DataGrid_AccessLevel.Name = "DataGrid_AccessLevel";
            this.DataGrid_AccessLevel.Size = new System.Drawing.Size(342, 288);
            this.DataGrid_AccessLevel.TabIndex = 0;
            // 
            // AccessLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataGrid_AccessLevel);
            this.Name = "AccessLevel";
            this.Text = "AccessLevel";
            this.Load += new System.EventHandler(this.AccessLevel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_AccessLevel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid_AccessLevel;
    }
}