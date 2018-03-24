using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coladera_de_Eratostenes
{
    public partial class frmMain : Form
    {
        LaColadera nueva;
        public frmMain()
        {
            InitializeComponent();
            nueva = new LaColadera(1000);
        }
        private void otroVoid()
        {
            nueva.controlNoPrimos();
            for (int i = 0; i < nueva.maximo; i++)
            {
                int n = nueva.mostrar(i);
                if (n != 0)
                    textBox1.Text += n + ", ";
            }
        }
        private void mostrarResultados()
        {
            nueva.colar();
            otroVoid();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            mostrarResultados();
        }
    }
}
