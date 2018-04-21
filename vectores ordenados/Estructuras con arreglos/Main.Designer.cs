namespace Estructuras_con_arreglos
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
            this.lblOne = new System.Windows.Forms.Label();
            this.txtDatoNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtDatoCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDatoCantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDatoCosto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOne
            // 
            this.lblOne.AutoSize = true;
            this.lblOne.Location = new System.Drawing.Point(15, 22);
            this.lblOne.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblOne.Name = "lblOne";
            this.lblOne.Size = new System.Drawing.Size(84, 22);
            this.lblOne.TabIndex = 0;
            this.lblOne.Text = "Nombre";
            // 
            // txtDatoNombre
            // 
            this.txtDatoNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDatoNombre.Location = new System.Drawing.Point(164, 22);
            this.txtDatoNombre.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtDatoNombre.Name = "txtDatoNombre";
            this.txtDatoNombre.Size = new System.Drawing.Size(180, 24);
            this.txtDatoNombre.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(379, 27);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 32);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtDatoCodigo
            // 
            this.txtDatoCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDatoCodigo.Location = new System.Drawing.Point(164, 65);
            this.txtDatoCodigo.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtDatoCodigo.Name = "txtDatoCodigo";
            this.txtDatoCodigo.Size = new System.Drawing.Size(180, 24);
            this.txtDatoCodigo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Código";
            // 
            // txtDatoCantidad
            // 
            this.txtDatoCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDatoCantidad.Location = new System.Drawing.Point(164, 108);
            this.txtDatoCantidad.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtDatoCantidad.Name = "txtDatoCantidad";
            this.txtDatoCantidad.Size = new System.Drawing.Size(180, 24);
            this.txtDatoCantidad.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cantidad";
            // 
            // txtDatoCosto
            // 
            this.txtDatoCosto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDatoCosto.Location = new System.Drawing.Point(164, 155);
            this.txtDatoCosto.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtDatoCosto.Name = "txtDatoCosto";
            this.txtDatoCosto.Size = new System.Drawing.Size(180, 24);
            this.txtDatoCosto.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Costo";
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRespuesta.Location = new System.Drawing.Point(19, 205);
            this.txtRespuesta.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtRespuesta.Multiline = true;
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRespuesta.Size = new System.Drawing.Size(561, 126);
            this.txtRespuesta.TabIndex = 9;
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(379, 65);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 32);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnListar
            // 
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListar.Location = new System.Drawing.Point(379, 145);
            this.btnListar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(100, 32);
            this.btnListar.TabIndex = 11;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(379, 103);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 32);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 356);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtRespuesta);
            this.Controls.Add(this.txtDatoCosto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDatoCantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDatoCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtDatoNombre);
            this.Controls.Add(this.lblOne);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmMain";
            this.Text = "Estructuras arremangadas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOne;
        private System.Windows.Forms.TextBox txtDatoNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtDatoCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDatoCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDatoCosto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRespuesta;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnEliminar;
    }
}

