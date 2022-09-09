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
using static System.Net.WebRequestMethods;
using File = System.IO.File;

namespace ArchivosPlanos
{
    public partial class frmXml : Form
    {
        
        string rutaArchivo = string.Empty;
        public frmXml()
        {
            InitializeComponent();
        }
        OpenFileDialog fileDialog = new OpenFileDialog()
        {
            Filter = "Archivo (*.xml) | *.xml"
        };
        private Stream myStream;

        private void btnLeerXML_Click(object sender, EventArgs e)
        {
            try
            {
                txtArchivo.Clear();
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {                         
                    try
                    {
                        rutaArchivo = fileDialog.FileName;
                        var fileStream = new FileStream(rutaArchivo, FileMode.Open);
                        var leer = new StreamReader(fileStream);
                        txtArchivo.Text = leer.ReadToEnd();
                        leer.Close();
                        

                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("No ha seleccionado nada. " + error.Message);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        private void btnModificarXML_Click(object sender, EventArgs e)
        { 
            DialogResult alerta = MessageBox.Show("Modificará el ultimo archivo leído con exactamente lo que haya en la caja de texto.\rDesea continuar?", "Cuidado", MessageBoxButtons.OKCancel);
            if (alerta == DialogResult.OK)
            {
                string[] lineas = { txtArchivo.Text };
                using (StreamWriter sw = new StreamWriter(rutaArchivo))
                {
                    foreach (string linea in lineas)
                    {
                        sw.WriteLine(linea);
                    }
                    sw.Close();
                }
                MessageBox.Show("Archivo modificado con exito", "Cambios realizados");
            }
        }
        private void btnEliminarXML_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult alerta = MessageBox.Show("Eliminará el ultimo archivo leído con exactamente lo que haya en la caja de texto.\rDesea continuar?", "Cuidado", MessageBoxButtons.OKCancel);
                if (alerta == DialogResult.OK)
                {
                    File.Delete(rutaArchivo);
                    txtArchivo.Clear();
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

        private void btnCrearXML_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "Archivos XML (*.xml)| *.xml"
            };
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveDialog.FileName);
                streamWriter.Write(txtArchivo.Text);
                MessageBox.Show("Archivo creado con exito");
                streamWriter.Close();
                txtArchivo.Clear();
            }
        }
    }
}
