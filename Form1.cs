using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reproductor
{
    public partial class Form1 : Form
    {
        private string ruta = "";
        string[] rutaArch;
        string[] archivo;
        public Form1()
        {
            InitializeComponent();
        }               

        private void pbx4_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ruta = openFileDialog1.FileName;
                lbl1.Text = ruta;               
            }            
        }

        private void pbxPlay_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = ruta;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
        private void pbxPause_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }
        private void pbxNext_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.next();
        }

        private void pbxPrevious_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.previous();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            OpenFileDialog Archivos = new OpenFileDialog();
            Archivos.Multiselect = true;

            if (Archivos.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                archivo = Archivos.SafeFileNames;
                rutaArch = Archivos.FileNames;
                foreach(var archivoMP3 in archivo)
                {
                    lstLista.Items.Add(archivoMP3);
                }
                axWindowsMediaPlayer1.URL = rutaArch[0];
                lstLista.SelectedIndex = 0;
            }
        }
    }
}
