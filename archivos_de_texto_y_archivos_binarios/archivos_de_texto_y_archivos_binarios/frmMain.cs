using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace archivos_de_texto_y_archivos_binarios
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void CrearContactoAgendaXml()
        {
            sfdGuardadorArchivos.Filter = ".xml| *.xml";
            sfdGuardadorArchivos.ShowDialog();
            FileStream streamArchivo = new FileStream(sfdGuardadorArchivos.FileName, FileMode.Create);
            XmlTextWriter escritorXml = new XmlTextWriter(streamArchivo, System.Text.Encoding.UTF8);
            escritorXml.Formatting = Formatting.Indented;
            escritorXml.WriteStartDocument(); 
            escritorXml.WriteStartElement("Contacto");
            escritorXml.WriteElementString("Nombre:", txtNombreDelDude.Text);
            escritorXml.WriteElementString("Direccion:", txtDireccionEnriqueSegoviano.Text);
            escritorXml.WriteElementString("Telefono:", txtPhono.Text);
            escritorXml.WriteElementString("Familia o Amigos:", txtFamiliaAmigos.Text);
            escritorXml.WriteElementString("Correo Electronico", txtCorreoElectronico.Text);
            escritorXml.WriteEndElement();
            escritorXml.WriteEndDocument();
            escritorXml.Flush();
            escritorXml.Close();
        }
        public bool validadorBmp(FileStream streamBmp)
        {
            BinaryReader lectorBinario = new BinaryReader(streamBmp);
            lectorBinario.BaseStream.Seek(0, SeekOrigin.Begin);
            int control = lectorBinario.ReadInt16();
            if (control == 19778)
                return true;
            else
                return false;
        }
        public string ObtenerDatosBmp()
        {
            ofdAbreArchivos.ShowDialog();
            FileStream streamArchivo = new FileStream(ofdAbreArchivos.FileName, FileMode.Open);
            if (validadorBmp(streamArchivo))
            {
                int altura = 0, anchura = 0, pixeles = 0, bitsPorPixel = 0;
                BinaryReader lectorBinario = new BinaryReader(streamArchivo);
                lectorBinario.BaseStream.Seek(2, SeekOrigin.Begin);
                pixeles = lectorBinario.ReadInt32();
                lectorBinario.BaseStream.Seek(12, SeekOrigin.Current);
                anchura = lectorBinario.ReadInt32();
                altura = lectorBinario.ReadInt32();
                lectorBinario.BaseStream.Seek(2, SeekOrigin.Current);
                bitsPorPixel = lectorBinario.ReadInt16();
                lectorBinario.Close();
                return "Archivo BMP detectado... \nTamaño: " + pixeles.ToString() + "\nAlto: " + altura.ToString() +
                    "\nAncho: " + anchura.ToString() + "\nBits por pixel: " + bitsPorPixel.ToString();
            }
            else
            {
                MessageBox.Show("Archivo BMP NO detectado...");
                streamArchivo.Close();
                return null;
            }
        }
        private void btnSelectArchivo_Click(object sender, EventArgs e)
        {
            if (txtNombreDelDude.Text == "")
                MessageBox.Show("Campos vacíos");
            else
                CrearContactoAgendaXml();
        }
        private void btnSelectBmp_Click(object sender, EventArgs e)
        {
            txtDatosBmp.Text = ObtenerDatosBmp();
        }
    }
}
