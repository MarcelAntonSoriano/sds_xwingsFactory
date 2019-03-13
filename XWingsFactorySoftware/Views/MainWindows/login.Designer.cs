namespace XWingsFactorySoftware
{
    partial class login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_cancelar = new AltoControls.AltoButton();
            this.Btn_aceptar = new AltoControls.AltoButton();
            this.altoTextBox2 = new AltoControls.AltoTextBox();
            this.altoTextBox1 = new AltoControls.AltoTextBox();
            this.SuspendLayout();
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.Btn_cancelar.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.Btn_cancelar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Btn_cancelar.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_cancelar.ForeColor = System.Drawing.Color.Black;
            this.Btn_cancelar.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(188)))), ((int)(((byte)(210)))));
            this.Btn_cancelar.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(167)))), ((int)(((byte)(188)))));
            this.Btn_cancelar.Location = new System.Drawing.Point(176, 297);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Radius = 10;
            this.Btn_cancelar.Size = new System.Drawing.Size(91, 27);
            this.Btn_cancelar.Stroke = false;
            this.Btn_cancelar.StrokeColor = System.Drawing.Color.Gray;
            this.Btn_cancelar.TabIndex = 7;
            this.Btn_cancelar.Text = "Cancelar";
            this.Btn_cancelar.Transparency = false;
            // 
            // Btn_aceptar
            // 
            this.Btn_aceptar.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.Btn_aceptar.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.Btn_aceptar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_aceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Btn_aceptar.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_aceptar.ForeColor = System.Drawing.Color.Black;
            this.Btn_aceptar.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(188)))), ((int)(((byte)(210)))));
            this.Btn_aceptar.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(167)))), ((int)(((byte)(188)))));
            this.Btn_aceptar.Location = new System.Drawing.Point(49, 297);
            this.Btn_aceptar.Name = "Btn_aceptar";
            this.Btn_aceptar.Radius = 10;
            this.Btn_aceptar.Size = new System.Drawing.Size(91, 27);
            this.Btn_aceptar.Stroke = false;
            this.Btn_aceptar.StrokeColor = System.Drawing.Color.Gray;
            this.Btn_aceptar.TabIndex = 6;
            this.Btn_aceptar.Text = "Aceptar";
            this.Btn_aceptar.Transparency = false;
            this.Btn_aceptar.Click += new System.EventHandler(this.Btn_aceptar_Click);
            // 
            // altoTextBox2
            // 
            this.altoTextBox2.BackColor = System.Drawing.Color.Transparent;
            this.altoTextBox2.Br = System.Drawing.Color.White;
            this.altoTextBox2.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.altoTextBox2.ForeColor = System.Drawing.Color.Black;
            this.altoTextBox2.Location = new System.Drawing.Point(94, 209);
            this.altoTextBox2.Name = "altoTextBox2";
            this.altoTextBox2.Size = new System.Drawing.Size(135, 28);
            this.altoTextBox2.TabIndex = 5;
            // 
            // altoTextBox1
            // 
            this.altoTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.altoTextBox1.Br = System.Drawing.Color.White;
            this.altoTextBox1.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.altoTextBox1.ForeColor = System.Drawing.Color.Black;
            this.altoTextBox1.Location = new System.Drawing.Point(94, 161);
            this.altoTextBox1.Name = "altoTextBox1";
            this.altoTextBox1.Size = new System.Drawing.Size(135, 28);
            this.altoTextBox1.TabIndex = 4;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 408);
            this.Controls.Add(this.Btn_cancelar);
            this.Controls.Add(this.Btn_aceptar);
            this.Controls.Add(this.altoTextBox2);
            this.Controls.Add(this.altoTextBox1);
            this.Name = "login";
            this.Text = "LOGIN";
            this.ResumeLayout(false);

        }

        #endregion

        private AltoControls.AltoButton Btn_cancelar;
        private AltoControls.AltoButton Btn_aceptar;
        private AltoControls.AltoTextBox altoTextBox2;
        private AltoControls.AltoTextBox altoTextBox1;
    }
}

