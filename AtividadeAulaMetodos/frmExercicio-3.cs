using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeAulaMetodos
{
    public partial class frmExercicio_3 : Form
    {
        public frmExercicio_3()
        {
            InitializeComponent();
        }

        private void Limpar()
        {
            txtCampo1.Text = null;
            txtCampo2.Text = null;
            txtCampo3.Text = null;
            txtCampo4.Text = null;
        }

        private void Habilitar()
        {
            txtCampo1.Enabled = true;
            txtCampo2.Enabled = true;
            txtCampo3.Enabled = true;
            txtCampo4.Enabled = true;
        }

        private void Desabilitar()
        {
            txtCampo1.Enabled = false;
            txtCampo2.Enabled = false;
            txtCampo3.Enabled = false;
            txtCampo4.Enabled = false;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            Habilitar();
        }

        private void btnDesabilitar_Click(object sender, EventArgs e)
        {
            Desabilitar();
        }
    }
}
