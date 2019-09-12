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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void exerc1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio_1 tela = new frmExercicio_1();
            tela.MdiParent = this;
            tela.Show();
        }

        private void exercício2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio_2 tela = new frmExercicio_2();
            tela.MdiParent = this;
            tela.Show();
        }

        private void exerc3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio_3 tela = new frmExercicio_3();
            tela.MdiParent = this;
            tela.Show();
        }

        private void exerc4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio_4 tela = new frmExercicio_4();
            tela.MdiParent = this;
            tela.Show();
        }
    }
}
