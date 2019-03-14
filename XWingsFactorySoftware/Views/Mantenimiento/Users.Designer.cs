namespace XWingsFactorySoftware.Views.Mantenimiento
{
    partial class Users
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
            this.DataGrid_Users = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Combo_tipo = new System.Windows.Forms.ComboBox();
            this.TextBox_nombre = new System.Windows.Forms.TextBox();
            this.Btn_new = new AltoControls.AltoButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Users)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid_Users
            // 
            this.DataGrid_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Users.Location = new System.Drawing.Point(50, 101);
            this.DataGrid_Users.Name = "DataGrid_Users";
            this.DataGrid_Users.Size = new System.Drawing.Size(306, 305);
            this.DataGrid_Users.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(393, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(393, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo:";
            // 
            // Combo_tipo
            // 
            this.Combo_tipo.FormattingEnabled = true;
            this.Combo_tipo.Items.AddRange(new object[] {
            "Operario",
            "Ingeniero",
            "Administrador"});
            this.Combo_tipo.Location = new System.Drawing.Point(507, 182);
            this.Combo_tipo.Name = "Combo_tipo";
            this.Combo_tipo.Size = new System.Drawing.Size(176, 21);
            this.Combo_tipo.TabIndex = 4;
            // 
            // TextBox_nombre
            // 
            this.TextBox_nombre.Location = new System.Drawing.Point(507, 114);
            this.TextBox_nombre.Name = "TextBox_nombre";
            this.TextBox_nombre.Size = new System.Drawing.Size(176, 20);
            this.TextBox_nombre.TabIndex = 5;
            // 
            // Btn_new
            // 
            this.Btn_new.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.Btn_new.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.Btn_new.BackColor = System.Drawing.Color.Transparent;
            this.Btn_new.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Btn_new.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_new.ForeColor = System.Drawing.Color.Black;
            this.Btn_new.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(188)))), ((int)(((byte)(210)))));
            this.Btn_new.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(167)))), ((int)(((byte)(188)))));
            this.Btn_new.Location = new System.Drawing.Point(596, 252);
            this.Btn_new.Name = "Btn_new";
            this.Btn_new.Radius = 10;
            this.Btn_new.Size = new System.Drawing.Size(87, 37);
            this.Btn_new.Stroke = false;
            this.Btn_new.StrokeColor = System.Drawing.Color.Gray;
            this.Btn_new.TabIndex = 6;
            this.Btn_new.Text = "Nuevo";
            this.Btn_new.Transparency = false;
            this.Btn_new.Click += new System.EventHandler(this.Btn_new_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_new);
            this.Controls.Add(this.TextBox_nombre);
            this.Controls.Add(this.Combo_tipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGrid_Users);
            this.Name = "Users";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Users)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid_Users;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Combo_tipo;
        private System.Windows.Forms.TextBox TextBox_nombre;
        private AltoControls.AltoButton Btn_new;
    }
}