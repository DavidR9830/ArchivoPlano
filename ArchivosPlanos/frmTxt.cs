using System.Windows.Forms;

namespace ArchivosPlanos
{
    public partial class frmTxt : Form
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        string rutaArchivo = string.Empty;
        SaveFileDialog saveDialog = new SaveFileDialog();
     

        public frmTxt()
        {
            InitializeComponent();
            
            saveDialog.Filter = "Text Files | *.txt";
            saveDialog.DefaultExt = "txt";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                rutaArchivo = openFileDialog.FileName;
                var fileStream = new FileStream(rutaArchivo, FileMode.Open);
                var leer = new StreamReader(fileStream);
                txt1.Text = leer.ReadToEnd();
                leer.Close();
            }
          

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var fileStream = new FileStream(rutaArchivo, FileMode.Truncate);
            var escribir = new StreamWriter(fileStream);
            escribir.Write(txt1.Text);
            MessageBox.Show("Archivo modificado con éxito");
            escribir.Close();
            txt1.Clear();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                rutaArchivo = saveDialog.FileName;
                var fileStream = new FileStream(rutaArchivo, FileMode.Create);
                var crear = new StreamWriter(fileStream);
                crear.Write(txt1.Text);
                MessageBox.Show("Archivo creado con éxito");
                crear.Close();
                txt1.Clear();
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
                   txt1.Clear();
                    MessageBox.Show("Archivo Eliminado con exito");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Debe leer o modificar un archivo antes de eliminarlo. " + error.Message, "Recuerde");
            }

        }
    }
}