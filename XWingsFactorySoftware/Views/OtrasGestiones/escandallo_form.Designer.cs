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
            this.treeView = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_Desc = new System.Windows.Forms.TextBox();
            this.txtBox_Code = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.derecha = new System.Windows.Forms.Button();
            this.izquierda = new System.Windows.Forms.Button();
            this.integrantesClan = new System.Windows.Forms.ListBox();
            this.alumnos = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(26, 115);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(323, 543);
            this.treeView.TabIndex = 0;
            this.treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBox_Desc);
            this.groupBox1.Controls.Add(this.txtBox_Code);
            this.groupBox1.Location = new System.Drawing.Point(419, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(638, 335);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Producto Seleccionado";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(18, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripción";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código";
            // 
            // txtBox_Desc
            // 
            this.txtBox_Desc.Location = new System.Drawing.Point(271, 46);
            this.txtBox_Desc.Name = "txtBox_Desc";
            this.txtBox_Desc.Size = new System.Drawing.Size(181, 20);
            this.txtBox_Desc.TabIndex = 1;
            // 
            // txtBox_Code
            // 
            this.txtBox_Code.Location = new System.Drawing.Point(61, 46);
            this.txtBox_Code.Name = "txtBox_Code";
            this.txtBox_Code.Size = new System.Drawing.Size(107, 20);
            this.txtBox_Code.TabIndex = 0;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(918, 649);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(101, 23);
            this.btSave.TabIndex = 18;
            this.btSave.Text = "Guardar";
            this.btSave.UseVisualStyleBackColor = true;
            // 
            // derecha
            // 
            this.derecha.Location = new System.Drawing.Point(718, 516);
            this.derecha.Name = "derecha";
            this.derecha.Size = new System.Drawing.Size(75, 23);
            this.derecha.TabIndex = 17;
            this.derecha.Text = "> >";
            this.derecha.UseVisualStyleBackColor = true;
            // 
            // izquierda
            // 
            this.izquierda.Location = new System.Drawing.Point(718, 462);
            this.izquierda.Name = "izquierda";
            this.izquierda.Size = new System.Drawing.Size(75, 23);
            this.izquierda.TabIndex = 16;
            this.izquierda.Text = "< <";
            this.izquierda.UseVisualStyleBackColor = true;
            // 
            // integrantesClan
            // 
            this.integrantesClan.AllowDrop = true;
            this.integrantesClan.FormattingEnabled = true;
            this.integrantesClan.Location = new System.Drawing.Point(827, 449);
            this.integrantesClan.Name = "integrantesClan";
            this.integrantesClan.Size = new System.Drawing.Size(192, 160);
            this.integrantesClan.TabIndex = 15;
            // 
            // alumnos
            // 
            this.alumnos.AllowDrop = true;
            this.alumnos.FormattingEnabled = true;
            this.alumnos.Location = new System.Drawing.Point(489, 449);
            this.alumnos.Name = "alumnos";
            this.alumnos.Size = new System.Drawing.Size(192, 160);
            this.alumnos.TabIndex = 14;
            // 
            // escandallo_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 738);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.derecha);
            this.Controls.Add(this.izquierda);
            this.Controls.Add(this.integrantesClan);
            this.Controls.Add(this.alumnos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.treeView);
            this.Name = "escandallo_form";
            this.Text = "Escandallo";
            this.Load += new System.EventHandler(this.escandallo_form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_Desc;
        private System.Windows.Forms.TextBox txtBox_Code;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button derecha;
        private System.Windows.Forms.Button izquierda;
        private System.Windows.Forms.ListBox integrantesClan;
        private System.Windows.Forms.ListBox alumnos;
    }
}