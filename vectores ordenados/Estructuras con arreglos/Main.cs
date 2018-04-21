using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estructuras_con_arreglos
{
    public partial class frmMain : Form
    {
        string nombre = "";
        int codigo = 0, posicion = 0;
        double cantidad = 0, costo = 0;
        Producto producto;
        Producto[] vectorPrincipal = new Producto[15];

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDatoNombre.Text) && !string.IsNullOrEmpty(txtDatoCodigo.Text)
                && !string.IsNullOrEmpty(txtDatoCantidad.Text) && !string.IsNullOrEmpty(txtDatoCosto.Text))
            {
                ReadySet();
                producto = new Producto(nombre, codigo, cantidad, costo);
                if (producto.ValidarVectorUsuario(vectorPrincipal))
                    MessageBox.Show("Capacidad de registro llena", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (producto.ValidarCodigoUsuario(codigo, vectorPrincipal))
                    MessageBox.Show("Producto ya registrado", "AViSO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (!producto.ValidarCodigoUsuario(codigo, vectorPrincipal) && !producto.ValidarVectorUsuario(vectorPrincipal))
                {
                    producto.AgregarProducto(producto, vectorPrincipal);
                    RayoMClean();
                    txtRespuesta.Text = producto.codigo.ToString();
                }

            }
            else
                MessageBox.Show("Todos los campos deben estar llenos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void ReadySet()
        {
            nombre = txtDatoNombre.Text;
            codigo = Convert.ToInt32(txtDatoCodigo.Text);
            cantidad = Convert.ToDouble(txtDatoCantidad.Text);
            costo = Convert.ToDouble(txtDatoCosto.Text);
        }

        public void RayoMClean()
        {
            txtDatoCantidad.Text = "";
            txtDatoCodigo.Text = "";
            txtDatoNombre.Text = "";
            txtDatoCosto.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDatoCodigo.Text))
            {
                codigo = Convert.ToInt32(txtDatoCodigo.Text);
                txtRespuesta.Text = Convert.ToString(producto.Buscar(Convert.ToInt32(codigo), vectorPrincipal));
            }
            else
                MessageBox.Show("Se debe llenar el campo de código", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDatoCodigo.Text))
            {
                codigo = Convert.ToInt32(txtDatoCodigo.Text);
                producto.Eliminar(codigo, vectorPrincipal);
            }
            else
                MessageBox.Show("Se debe llenar el campo de código", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            txtRespuesta.Clear();
            txtRespuesta.Text += producto.Listar(vectorPrincipal);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
