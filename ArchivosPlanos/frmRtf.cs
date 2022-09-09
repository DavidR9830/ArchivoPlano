using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchivosPlanos
{
    public partial class frmRtf : Form
    {
        OpenFileDialog openFileDialog = new OpenFileDialog()
        {
            Filter = "Archivos RTF (*.rtf) | *.rtf"
        };

        string rutaArchivo = string.Empty;
        SaveFileDialog saveDialog = new SaveFileDialog();
        public frmRtf()
        {
            InitializeComponent();
            saveDialog.Filter = "RTF Files | *.rtf";
            saveDialog.DefaultExt = "rtf";
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                rutaArchivo = saveDialog.FileName;
                var fileStream = new FileStream(rutaArchivo, FileMode.Create);
                var crear = new StreamWriter(fileStream);
                crear.Write(rtbArchivo.Rtf);
                MessageBox.Show("Archivo creado con éxito");
                crear.Close();
                rtbArchivo.Clear();
            }

        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                rutaArchivo = openFileDialog.FileName;
                var fileStream = new FileStream(rutaArchivo, FileMode.Open);
                var leer = new StreamReader(fileStream);
                rtbArchivo.Rtf = leer.ReadToEnd();
                leer.Close();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                var fileStream = new FileStream(rutaArchivo, FileMode.Truncate);
                var escribir = new StreamWriter(fileStream);
                escribir.Write(rtbArchivo.Rtf);
                MessageBox.Show("Archivo modificado con éxito");
                escribir.Close();
                rtbArchivo.Clear();
            }
            catch (Exception error)
            {
                MessageBox.Show("Debe leer un archivo antes de modificarlo. " + error.Message, "Recuerde");
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult alerta = MessageBox.Show("Eliminará el ultimo archivo leído con exactamente lo que haya en la caja de texto.\rDesea continuar?", "Cuidado", MessageBoxButtons.OKCancel);
                if (alerta == DialogResult.OK)
                {
                    File.Delete(rutaArchivo);
                    rtbArchivo.Clear();
                    MessageBox.Show("Archivo Eliminado con exito");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Debe leer o modificar un archivo antes de eliminarlo. " + error.Message, "Recuerde");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmHome frmHome = new frmHome();
            frmHome.Show();
            this.Hide();
        }
    }
}
