using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carrera_libre_y_tortuga
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        ElTorto torto = new ElTorto("Torto");
        LaLibre libre = new LaLibre("Libre");
        private void Anunciador(int controlDelTorto, int controlDeLaLibre, ElTorto torto,LaLibre libre)
        {
            if (controlDelTorto > controlDeLaLibre)
                txtOutPut.Text += "El ganador es: " + torto.nombre;
            else if (controlDelTorto < controlDeLaLibre)
                txtOutPut.Text += "El ganador es: " + libre.nombre;
            else
                txtOutPut.Text += "Es un empate";
        }
        private void CorrerSimulacion(ElTorto torto, LaLibre libre)
        {
            int controlDelTorto = 0, controlDeLaLibre = 0;
            while (controlDeLaLibre < 80 && controlDelTorto < 80)
            {
                controlDelTorto += torto.darleCandela();
                controlDeLaLibre += libre.darleCandela();

                txtOutPut.Text += torto.nombre + " avanzó: " + controlDelTorto + " pasos" + Environment.NewLine 
                    + libre.nombre + " avanzó: " + controlDeLaLibre + " pasos" + Environment.NewLine;
            }
            Anunciador(controlDelTorto, controlDeLaLibre, torto, libre);
        }
        private void btnDarleCandela_Click(object sender, EventArgs e)
        {
            CorrerSimulacion(torto, libre);
        }
    }
}
