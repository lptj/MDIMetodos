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
    public partial class frmExercicio_4 : Form
    {
        public frmExercicio_4()
        {
            InitializeComponent();
        }

        private double CalculoImc(double p, double a)
        {
            return p / (a * a);
        }

        private string Situacao(double x)
        {
            if (x < 17)
            {
                return "Muito abaixo do peso";
            }else if (x > 17 && x < 18.49)
            {
                return "Abaixo do peso";
            }else if (x > 18.5 && x < 24.99)
            {
                return "Peso normal";
            }else if (x > 25 && x < 29.99)
            {
                return "Acima do peso";
            }else if (x > 30 && x < 34.99)
            {
                return "Obesidade I";
            }else if (x > 34 && x < 39.99)
            {
                return "Obesidade II (severa)";
            }
            else
            {
                return "Obesidade III (mórida)";
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso = Convert.ToDouble(txtPeso.Text);
            double altura = Convert.ToDouble(txtAltura.Text);
            double imc;
            string situacao;

            imc = CalculoImc(peso, altura);
            situacao = Situacao(imc);

            MessageBox.Show("IMC: " + imc + " " + situacao);


        }
    }
}
