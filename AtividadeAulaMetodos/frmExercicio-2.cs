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
    public partial class frmExercicio_2 : Form
    {
        public frmExercicio_2()
        {
            InitializeComponent();
        }

        private double Fahrenheit(double x)
        {
            return x * 9 / 5 + 32;
        }

        private double Kelvin(double x)
        {
            return x + 273.15;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double c = Convert.ToDouble(txtCelcius.Text);
            double f;
            double k;

            f = Fahrenheit(c);
            k = Kelvin(c);

            txtFahrenheit.Text = Convert.ToString(f);
            txtKelvin.Text = Convert.ToString(k);
        }
    }
}
