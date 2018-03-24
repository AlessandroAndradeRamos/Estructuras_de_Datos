namespace carrera_libre_y_tortuga
{
    partial class frmMain
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
            this.txtOutPut = new System.Windows.Forms.TextBox();
            this.btnDarleCandela = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtOutPut
            // 
            this.txtOutPut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtOutPut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOutPut.Location = new System.Drawing.Point(12, 111);
            this.txtOutPut.Multiline = true;
            this.txtOutPut.Name = "txtOutPut";
            this.txtOutPut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutPut.Size = new System.Drawing.Size(320, 349);
            this.txtOutPut.TabIndex = 0;
            // 
            // btnDarleCandela
            // 
            this.btnDarleCandela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDarleCandela.Location = new System.Drawing.Point(12, 68);
            this.btnDarleCandela.Name = "btnDarleCandela";
            this.btnDarleCandela.Size = new System.Drawing.Size(320, 37);
            this.btnDarleCandela.TabIndex = 1;
            this.btnDarleCandela.Text = "Simular carrera";
            this.btnDarleCandela.UseVisualStyleBackColor = true;
            this.btnDarleCandela.Click += new System.EventHandler(this.btnDarleCandela_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Liebre vs tortuga";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(344, 472);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDarleCandela);
            this.Controls.Add(this.txtOutPut);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOutPut;
        private System.Windows.Forms.Button btnDarleCandela;
        private System.Windows.Forms.Label label1;
    }
}

