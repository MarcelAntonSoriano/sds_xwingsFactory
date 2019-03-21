namespace Insings
{
    partial class escandallo_gestion
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
            this.derecha = new System.Windows.Forms.Button();
            this.izquierda = new System.Windows.Forms.Button();
            this.integrantesClan = new System.Windows.Forms.ListBox();
            this.alumnos = new System.Windows.Forms.ListBox();
            this.comboClan = new System.Windows.Forms.ComboBox();
            this.btSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // derecha
            // 
            this.derecha.Location = new System.Drawing.Point(275, 170);
            this.derecha.Name = "derecha";
            this.derecha.Size = new System.Drawing.Size(75, 23);
            this.derecha.TabIndex = 11;
            this.derecha.Text = "> >";
            this.derecha.UseVisualStyleBackColor = true;
            this.derecha.Click += new System.EventHandler(this.derecha_Click);
            // 
            // izquierda
            // 
            this.izquierda.Location = new System.Drawing.Point(275, 116);
            this.izquierda.Name = "izquierda";
            this.izquierda.Size = new System.Drawing.Size(75, 23);
            this.izquierda.TabIndex = 10;
            this.izquierda.Text = "< <";
            this.izquierda.UseVisualStyleBackColor = true;
            this.izquierda.Click += new System.EventHandler(this.izquierda_Click);
            // 
            // integrantesClan
            // 
            this.integrantesClan.AllowDrop = true;
            this.integrantesClan.FormattingEnabled = true;
            this.integrantesClan.Location = new System.Drawing.Point(384, 103);
            this.integrantesClan.Name = "integrantesClan";
            this.integrantesClan.Size = new System.Drawing.Size(192, 160);
            this.integrantesClan.TabIndex = 9;
            this.integrantesClan.DragDrop += new System.Windows.Forms.DragEventHandler(this.integrantesClan_DragDrop);
            this.integrantesClan.DragOver += new System.Windows.Forms.DragEventHandler(this.integrantesClan_DragOver);
            this.integrantesClan.MouseDown += new System.Windows.Forms.MouseEventHandler(this.integrantesClan_MouseDown);
            // 
            // alumnos
            // 
            this.alumnos.AllowDrop = true;
            this.alumnos.FormattingEnabled = true;
            this.alumnos.Location = new System.Drawing.Point(46, 103);
            this.alumnos.Name = "alumnos";
            this.alumnos.Size = new System.Drawing.Size(192, 160);
            this.alumnos.TabIndex = 8;
            this.alumnos.DragDrop += new System.Windows.Forms.DragEventHandler(this.alumnos_DragDrop);
            this.alumnos.DragOver += new System.Windows.Forms.DragEventHandler(this.alumnos_DragOver);
            this.alumnos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.alumnos_MouseDown);
            // 
            // comboClan
            // 
            this.comboClan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboClan.FormattingEnabled = true;
            this.comboClan.Location = new System.Drawing.Point(384, 46);
            this.comboClan.Name = "comboClan";
            this.comboClan.Size = new System.Drawing.Size(192, 21);
            this.comboClan.TabIndex = 7;
            this.comboClan.SelectedIndexChanged += new System.EventHandler(this.comboClan_SelectedIndexChanged);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(475, 303);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(101, 23);
            this.btSave.TabIndex = 12;
            this.btSave.Text = "Guardar";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 402);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.derecha);
            this.Controls.Add(this.izquierda);
            this.Controls.Add(this.integrantesClan);
            this.Controls.Add(this.alumnos);
            this.Controls.Add(this.comboClan);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button derecha;
        private System.Windows.Forms.Button izquierda;
        private System.Windows.Forms.ListBox integrantesClan;
        private System.Windows.Forms.ListBox alumnos;
        private System.Windows.Forms.ComboBox comboClan;
        private System.Windows.Forms.Button btSave;
    }
}

