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

namespace ArchivosPlanos
{
    public partial class Archivosplanos : Form
    {
        public string ARCHIVO = "";
        public Archivosplanos()
        {
            InitializeComponent();
        }

        public void abrir()
        {
            try
            {
                this.openFileDialog1.ShowDialog();

                if (!string.IsNullOrEmpty(this.openFileDialog1.FileName))
                {
                    ARCHIVO = this.openFileDialog1.FileName;
                    StreamReader objReader = new StreamReader(ARCHIVO);
                    txtvisual.Text = objReader.ReadLine();
                    objReader.Close();
                    try
                    {
                        StreamReader sw = new StreamReader(ARCHIVO);
                        string linea = "";
                        linea = sw.ReadLine();
                        if (linea != null)
                        {
                            while (linea != null)
                            {
                                string[] dato = linea.Split();
                                linea = sw.ReadLine();
                                txtvisual.Text = string.Format("{0}{1}{2}", txtvisual.Text, Environment.NewLine, linea);
                            }
                        }
                        sw.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No ha seleccionado nada");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }

        }
        private void btnabrir_Click(object sender, EventArgs e)
        {
            txtvisual.Text="";
            abrir();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            string[] lineas = { txtvisual.Text };
            using(StreamWriter sw = new StreamWriter(ARCHIVO))
            {
                foreach(string linea in lineas)
                {
                    sw.WriteLine(linea);
                }
                sw.Close();
            }
        }
        private void btneliminar_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.FileName = null;
            this.openFileDialog1.ShowDialog();

            if (!string.IsNullOrEmpty(this.openFileDialog1.FileName))
            {
                ARCHIVO = this.openFileDialog1.FileName;
                File.Delete(ARCHIVO);
            }
            else
            {
                MessageBox.Show("No ha seleccionado nada");
            }
            txtvisual.Text="";
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtvisual.Text = "";
        }
    }
}
