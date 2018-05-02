namespace el_torto
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
            this.btnPlumaArriba = new System.Windows.Forms.Button();
            this.txtTablero = new System.Windows.Forms.TextBox();
            this.txtBoneToPick = new System.Windows.Forms.TextBox();
            this.btnPlumaAbajo = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnAvanzar = new System.Windows.Forms.Button();
            this.btnIzquierda = new System.Windows.Forms.Button();
            this.btnDerecha = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPlumaArriba
            // 
            this.btnPlumaArriba.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlumaArriba.Location = new System.Drawing.Point(423, 35);
            this.btnPlumaArriba.Name = "btnPlumaArriba";
            this.btnPlumaArriba.Size = new System.Drawing.Size(109, 35);
            this.btnPlumaArriba.TabIndex = 0;
            this.btnPlumaArriba.Text = "Arriba";
            this.btnPlumaArriba.UseVisualStyleBackColor = true;
            this.btnPlumaArriba.Click += new System.EventHandler(this.btnPlumaArriba_Click);
            // 
            // txtTablero
            // 
            this.txtTablero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTablero.Location = new System.Drawing.Point(12, 120);
            this.txtTablero.Multiline = true;
            this.txtTablero.Name = "txtTablero";
            this.txtTablero.Size = new System.Drawing.Size(519, 342);
            this.txtTablero.TabIndex = 1;
            // 
            // txtBoneToPick
            // 
            this.txtBoneToPick.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoneToPick.Location = new System.Drawing.Point(13, 90);
            this.txtBoneToPick.Name = "txtBoneToPick";
            this.txtBoneToPick.Size = new System.Drawing.Size(109, 24);
            this.txtBoneToPick.TabIndex = 2;
            // 
            // btnPlumaAbajo
            // 
            this.btnPlumaAbajo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlumaAbajo.Location = new System.Drawing.Point(423, 76);
            this.btnPlumaAbajo.Name = "btnPlumaAbajo";
            this.btnPlumaAbajo.Size = new System.Drawing.Size(109, 35);
            this.btnPlumaAbajo.TabIndex = 3;
            this.btnPlumaAbajo.Text = "Abajo";
            this.btnPlumaAbajo.UseVisualStyleBackColor = true;
            this.btnPlumaAbajo.Click += new System.EventHandler(this.btnPlumaAbajo_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnd.Location = new System.Drawing.Point(423, 468);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(109, 35);
            this.btnEnd.TabIndex = 4;
            this.btnEnd.Text = "Fin";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Location = new System.Drawing.Point(13, 468);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(109, 35);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnAvanzar
            // 
            this.btnAvanzar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvanzar.Location = new System.Drawing.Point(228, 76);
            this.btnAvanzar.Name = "btnAvanzar";
            this.btnAvanzar.Size = new System.Drawing.Size(109, 35);
            this.btnAvanzar.TabIndex = 6;
            this.btnAvanzar.Text = "Avanzar";
            this.btnAvanzar.UseVisualStyleBackColor = true;
            this.btnAvanzar.Click += new System.EventHandler(this.btnAvanzar_Click);
            // 
            // btnIzquierda
            // 
            this.btnIzquierda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzquierda.Location = new System.Drawing.Point(170, 35);
            this.btnIzquierda.Name = "btnIzquierda";
            this.btnIzquierda.Size = new System.Drawing.Size(109, 35);
            this.btnIzquierda.TabIndex = 7;
            this.btnIzquierda.Text = "Izquierda";
            this.btnIzquierda.UseVisualStyleBackColor = true;
            this.btnIzquierda.Click += new System.EventHandler(this.btnIzquierda_Click);
            // 
            // btnDerecha
            // 
            this.btnDerecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDerecha.Location = new System.Drawing.Point(285, 35);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(109, 35);
            this.btnDerecha.TabIndex = 8;
            this.btnDerecha.Text = "Derecha";
            this.btnDerecha.UseVisualStyleBackColor = true;
            this.btnDerecha.Click += new System.EventHandler(this.btnDerecha_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(224, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Movimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(441, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Pluma";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 521);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDerecha);
            this.Controls.Add(this.btnIzquierda);
            this.Controls.Add(this.btnAvanzar);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnPlumaAbajo);
            this.Controls.Add(this.txtBoneToPick);
            this.Controls.Add(this.txtTablero);
            this.Controls.Add(this.btnPlumaArriba);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmMain";
            this.Text = "El torto caminando ando";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlumaArriba;
        private System.Windows.Forms.TextBox txtTablero;
        private System.Windows.Forms.TextBox txtBoneToPick;
        private System.Windows.Forms.Button btnPlumaAbajo;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnAvanzar;
        private System.Windows.Forms.Button btnIzquierda;
        private System.Windows.Forms.Button btnDerecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

