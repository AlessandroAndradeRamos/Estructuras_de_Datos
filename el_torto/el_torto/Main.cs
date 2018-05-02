using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace el_torto
{
    public partial class frmMain : Form
    {
        ElTorto elTorto;
        int pasos = 0;
        public frmMain()
        {
            InitializeComponent();
            elTorto = new ElTorto();
        }

        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoneToPick.Text))
            {
                pasos = Convert.ToInt32(txtBoneToPick.Text);
                elTorto.Avanzar(pasos);
            }
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            elTorto.GirarDerecha();
        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            elTorto.GirarIzquierda();
        }

        private void btnPlumaArriba_Click(object sender, EventArgs e)
        {
            elTorto.Arriba();
        }

        private void btnPlumaAbajo_Click(object sender, EventArgs e)
        {
            elTorto.Abajo();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            txtTablero.Clear();
            txtTablero.Text += elTorto.MostrarTablero();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
