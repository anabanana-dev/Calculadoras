using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Projeto_Cálculos
{
    public partial class frmCalcRadio : Form
    {

        public frmCalcRadio()
        {
            InitializeComponent();
        }

        private void grbOperacoes_Enter(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(txtBox1.Text);
            double n2 = double.Parse(txtBox2.Text);
            double calc;

            if (rdbSomar.Checked == true)
            {
                lblSinal.Text = "+";
                calc = n1 + n2;
                lblResultado.Text = calc.ToString();
            }
            else if (rdbSubtrair.Checked == true)
            {
                lblSinal.Text = "-";
                calc = n1 - n2;
                lblResultado.Text = calc.ToString();
            }
            else if (rdbDividir.Checked == true)
            {
                lblSinal.Text = "/";
                calc = n1 / n2;
                lblResultado.Text = calc.ToString();
            }
            else if (rdbMultiplicar.Checked == true)
            {
                lblSinal.Text = "*";
                calc = n1 * n2;
                lblResultado.Text = calc.ToString();
            }
            else if (rdbPotencia.Checked == true)
            {
                lblSinal.Text = "^";
                calc = Math.Round(Math.Pow(n1, n2));
                lblResultado.Text = calc.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(txtBox1.Text);
            double n2 = double.Parse(txtBox2.Text);
            double calc;

            switch (lblSinal.Text)
            {
                case "+":
                    calc = n1 + n2;
                    lblResultado.Text = calc.ToString();
                    break;
                case "-":
                    calc = n1 - n2;
                    lblResultado.Text = calc.ToString();
                    break;
                case "/":
                    calc = n1 / n2;
                    lblResultado.Text = calc.ToString();
                    break;
                case "*":
                    calc = n1 * n2;
                    lblResultado.Text = calc.ToString();
                    break;
                case "^":
                    calc = Math.Floor(Math.Pow(n1, n2));
                    lblResultado.Text = calc.ToString();
                    break;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rdbSomar_CheckedChanged(object sender, EventArgs e)
        {
            lblSinal.Text = "+";
        }

        private void rdbSubtrair_CheckedChanged(object sender, EventArgs e)
        {
            lblSinal.Text = "-";
        }

        private void rdbMultiplicar_CheckedChanged(object sender, EventArgs e)
        {
            lblSinal.Text = "*";
        }

        private void rdbDividir_CheckedChanged(object sender, EventArgs e)
        {
            lblSinal.Text = "/";
        }

        private void rdbPotencia_CheckedChanged(object sender, EventArgs e)
        {
            lblSinal.Text = "^";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBox1.Clear();
            txtBox2.Clear();
            lblSinal.Text = "?";
            lblResultado.Text = "?";
            txtBox1.Focus();
        }
    }
}
