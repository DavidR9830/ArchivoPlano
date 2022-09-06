using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ArchivosPlanos
{
    public partial class frmXML : Form
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        string rutaArchivo = string.Empty;
        SaveFileDialog saveDialog = new SaveFileDialog();
        public frmXML()
        {
            InitializeComponent();
            saveDialog.Filter = "xml Files | *.xml";
            saveDialog.DefaultExt = "xml";
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            List<persona> p1 = new List<persona>();
            XmlSerializer serial = new XmlSerializer(typeof(List<persona>));
            p1.Add(new persona() { id = 1, nombre = "julian" });
            p1.Add(new persona() { id = 2, nombre = "pedro" });

            if (saveDialog.ShowDialog() == DialogResult.OK) 
            {
                rutaArchivo = saveDialog.FileName;

                using (System.IO.FileStream fs = new FileStream(rutaArchivo, FileMode.Create, FileAccess.Write))
                {
                   
                    serial.Serialize(fs, p1);
                    MessageBox.Show("Creado");
                }
            }
            
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            List<persona> p1 = new List<persona>();
            XmlSerializer serial = new XmlSerializer(typeof(List<persona>));

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            
            {
                rutaArchivo = openFileDialog.FileName;
                using (System.IO.FileStream fs = new FileStream(rutaArchivo, FileMode.Open, FileAccess.Read)) 
                {
                    p1 = serial.Deserialize(fs) as List<persona>;
                    
                }
                dbgrdXML.DataSource = p1;

            }
                
          
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            List<persona> p1 = new List<persona>();
            XmlSerializer serial = new XmlSerializer(typeof(List<persona>));
            
               using (System.IO.FileStream fs = new FileStream(rutaArchivo, FileMode.Create, FileAccess.Write))
                {

                    serial.Serialize(fs, dbgrdXML.DataSource);
                    MessageBox.Show("Creado");
                }
            


        }
    }
}


