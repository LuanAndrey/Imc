using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Imc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso = double.Parse(txbPeso.Text);
            double altura = double.Parse(txbAltura.Text);
            double imc = peso / (altura * altura);
            lblResultado.Text = "IMC:" + imc.ToString("N2");

            if (imc < 18.5)
            {
                lblClassificacao.Text = "Abaixo do peso";
            }
            else if (imc >= 18.6 && imc <= 24.9)
            {
                lblClassificacao.Text = "Peso ideal (parabéns)";
            }
            else if (imc >= 25.0 && imc <= 29.9)
            {
                lblClassificacao.Text = "Levemente acima do peso";
            }
            else if (imc >= 30.0 && imc <= 34.9)
            {
                lblClassificacao.Text = "Obesidade grau I";
            }
            else if (imc >= 35.0 && imc <= 39.9)
            {
                lblClassificacao.Text = "Obesidade grau II (severa)";
            }
            else if (imc > 40.0)
            {
                lblClassificacao.Text = "Obesidade III (mórbida)";
            }
        }

        private void txbPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (txbPeso.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void txbPeso_TextChanged(object sender, EventArgs e)
        {
            if (txbPeso.Text.Substring(0) == ",")
                txbPeso.Text = "0" + txbPeso.Text;
        }

        private void txbAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (txbAltura.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void txbAltura_TextChanged(object sender, EventArgs e)
        {
            if (txbAltura.Text.Substring(0) == ",")
                txbAltura.Text = "0" + txbAltura.Text;
        }
    }
}
