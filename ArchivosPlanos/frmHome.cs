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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnTxt_Click(object sender, EventArgs e)
        {
            frmTxt frmTxt = new frmTxt();
            frmTxt.Show();
            this.Hide();
        }

        private void btnXml_Click(object sender, EventArgs e)
        {
            frmXml frmXml = new frmXml();
            frmXml.Show();
            this.Hide();

        }

        private void btnCsv_Click(object sender, EventArgs e)
        {
            frmCsv frmCsv = new frmCsv();
            frmCsv.Show();
            this.Hide();
        }

        private void btnRtf_Click(object sender, EventArgs e)
        {
            frmRtf frmRtf = new frmRtf();
            frmRtf.Show();
            this.Hide();
        }
    }
}
