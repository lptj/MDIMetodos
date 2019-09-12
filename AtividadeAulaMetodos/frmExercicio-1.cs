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
    public partial class frmExercicio_1 : Form
    {
        public frmExercicio_1()
        {
            InitializeComponent();
            txtSaldo.Text = "1000";
        }

        private int Depositar (int x, int y)
        {
            return x + y;
        }

        private int Sacar (int x, int y)
        {
            return x - y;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int saldo = Convert.ToInt32(txtSaldo.Text);
            int valor = Convert.ToInt32(txtValor.Text);

            if (rbtnDepositar.Checked)
            {
                saldo = Depositar(saldo, valor);
            }
            else
            {
                saldo = Sacar(saldo, valor);
            }

            txtSaldo.Text = Convert.ToString(saldo);
        }
    }
}
