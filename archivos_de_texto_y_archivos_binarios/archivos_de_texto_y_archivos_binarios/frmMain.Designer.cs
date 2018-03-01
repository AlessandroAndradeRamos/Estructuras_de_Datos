namespace archivos_de_texto_y_archivos_binarios
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
            this.txtDatosBmp = new System.Windows.Forms.TextBox();
            this.btnSelectBmp = new System.Windows.Forms.Button();
            this.btnSelectArchivo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreDelDude = new System.Windows.Forms.TextBox();
            this.txtDireccionEnriqueSegoviano = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFamiliaAmigos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ofdAbreArchivos = new System.Windows.Forms.OpenFileDialog();
            this.sfdGuardadorArchivos = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // txtDatosBmp
            // 
            this.txtDatosBmp.BackColor = System.Drawing.Color.Turquoise;
            this.txtDatosBmp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDatosBmp.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatosBmp.ForeColor = System.Drawing.Color.White;
            this.txtDatosBmp.Location = new System.Drawing.Point(12, 12);
            this.txtDatosBmp.Multiline = true;
            this.txtDatosBmp.Name = "txtDatosBmp";
            this.txtDatosBmp.Size = new System.Drawing.Size(292, 125);
            this.txtDatosBmp.TabIndex = 0;
            // 
            // btnSelectBmp
            // 
            this.btnSelectBmp.BackColor = System.Drawing.Color.Turquoise;
            this.btnSelectBmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectBmp.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectBmp.ForeColor = System.Drawing.Color.White;
            this.btnSelectBmp.Location = new System.Drawing.Point(334, 12);
            this.btnSelectBmp.Name = "btnSelectBmp";
            this.btnSelectBmp.Size = new System.Drawing.Size(208, 30);
            this.btnSelectBmp.TabIndex = 1;
            this.btnSelectBmp.Text = "Seleccionar BMP";
            this.btnSelectBmp.UseVisualStyleBackColor = false;
            this.btnSelectBmp.Click += new System.EventHandler(this.btnSelectBmp_Click);
            // 
            // btnSelectArchivo
            // 
            this.btnSelectArchivo.BackColor = System.Drawing.Color.Turquoise;
            this.btnSelectArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectArchivo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectArchivo.ForeColor = System.Drawing.Color.White;
            this.btnSelectArchivo.Location = new System.Drawing.Point(334, 322);
            this.btnSelectArchivo.Name = "btnSelectArchivo";
            this.btnSelectArchivo.Size = new System.Drawing.Size(208, 40);
            this.btnSelectArchivo.TabIndex = 2;
            this.btnSelectArchivo.Text = "Crear contacto XML";
            this.btnSelectArchivo.UseVisualStyleBackColor = false;
            this.btnSelectArchivo.Click += new System.EventHandler(this.btnSelectArchivo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // txtNombreDelDude
            // 
            this.txtNombreDelDude.BackColor = System.Drawing.Color.Turquoise;
            this.txtNombreDelDude.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreDelDude.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreDelDude.ForeColor = System.Drawing.Color.White;
            this.txtNombreDelDude.Location = new System.Drawing.Point(12, 184);
            this.txtNombreDelDude.Multiline = true;
            this.txtNombreDelDude.Name = "txtNombreDelDude";
            this.txtNombreDelDude.Size = new System.Drawing.Size(303, 40);
            this.txtNombreDelDude.TabIndex = 4;
            // 
            // txtDireccionEnriqueSegoviano
            // 
            this.txtDireccionEnriqueSegoviano.BackColor = System.Drawing.Color.Turquoise;
            this.txtDireccionEnriqueSegoviano.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccionEnriqueSegoviano.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionEnriqueSegoviano.ForeColor = System.Drawing.Color.White;
            this.txtDireccionEnriqueSegoviano.Location = new System.Drawing.Point(12, 254);
            this.txtDireccionEnriqueSegoviano.Multiline = true;
            this.txtDireccionEnriqueSegoviano.Name = "txtDireccionEnriqueSegoviano";
            this.txtDireccionEnriqueSegoviano.Size = new System.Drawing.Size(303, 40);
            this.txtDireccionEnriqueSegoviano.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dirección";
            // 
            // txtPhono
            // 
            this.txtPhono.BackColor = System.Drawing.Color.Turquoise;
            this.txtPhono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhono.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhono.ForeColor = System.Drawing.Color.White;
            this.txtPhono.Location = new System.Drawing.Point(15, 322);
            this.txtPhono.Multiline = true;
            this.txtPhono.Name = "txtPhono";
            this.txtPhono.Size = new System.Drawing.Size(300, 40);
            this.txtPhono.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Teléfono";
            // 
            // txtFamiliaAmigos
            // 
            this.txtFamiliaAmigos.BackColor = System.Drawing.Color.Turquoise;
            this.txtFamiliaAmigos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFamiliaAmigos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFamiliaAmigos.ForeColor = System.Drawing.Color.White;
            this.txtFamiliaAmigos.Location = new System.Drawing.Point(15, 390);
            this.txtFamiliaAmigos.Multiline = true;
            this.txtFamiliaAmigos.Name = "txtFamiliaAmigos";
            this.txtFamiliaAmigos.Size = new System.Drawing.Size(300, 40);
            this.txtFamiliaAmigos.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Familia o amigos";
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.BackColor = System.Drawing.Color.Turquoise;
            this.txtCorreoElectronico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreoElectronico.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoElectronico.ForeColor = System.Drawing.Color.White;
            this.txtCorreoElectronico.Location = new System.Drawing.Point(17, 461);
            this.txtCorreoElectronico.Multiline = true;
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(298, 40);
            this.txtCorreoElectronico.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 433);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Correo electrónico";
            // 
            // ofdAbreArchivos
            // 
            this.ofdAbreArchivos.FileName = "abreArchivos";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(554, 513);
            this.Controls.Add(this.txtCorreoElectronico);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFamiliaAmigos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPhono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDireccionEnriqueSegoviano);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreDelDude);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectArchivo);
            this.Controls.Add(this.btnSelectBmp);
            this.Controls.Add(this.txtDatosBmp);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmMain";
            this.Text = "archivos de texto y binarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDatosBmp;
        private System.Windows.Forms.Button btnSelectBmp;
        private System.Windows.Forms.Button btnSelectArchivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreDelDude;
        private System.Windows.Forms.TextBox txtDireccionEnriqueSegoviano;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFamiliaAmigos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog ofdAbreArchivos;
        private System.Windows.Forms.SaveFileDialog sfdGuardadorArchivos;
    }
}

