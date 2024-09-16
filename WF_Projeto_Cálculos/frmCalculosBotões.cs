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
    public partial class frmCalculosBotões : Form
    {
        public frmCalculosBotões()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void txtN2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtN1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblSinal_Click(object sender, EventArgs e)
        {

        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            //double representa números decimais
            double r;
            try {
                double a = double.Parse(txtN1.Text);
                double b = double.Parse(txtN2.Text);
                //Atribuindo o sinal
                lblSinal.Text = "+";
                //calculando a soma
                r = a + b;
                //Mostrando o Resultado
                lblResultado.Text = r.ToString();
            }
            catch(FormatException)
            {
                MessageBox.Show("Informe apenas números!");
            }

        }

        private void txtN1_TextAlignChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtN1.Clear();
            txtN2.Clear();
            lblSinal.Text = "?";
            lblResultado.Text = "?";
            txtN1.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            double r;
            try
            {
                double a = double.Parse(txtN1.Text);
                double b = double.Parse(txtN2.Text);
                //Atribuindo o sinal
                lblSinal.Text = "-";
                //calculando a subtração
                r = a - b;
                //Mostrando o Resultado
                lblResultado.Text = r.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números!");
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            double r;
            try
            {
                double a = double.Parse(txtN1.Text);
                double b = double.Parse(txtN2.Text);
                //Atribuindo o sinal
                lblSinal.Text = "*";
                //calculando a multiplicação
                r = a * b;
                //Mostrando o Resultado
                lblResultado.Text = r.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números!");
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double r;
            try
            {
                double a = double.Parse(txtN1.Text);
                double b = double.Parse(txtN2.Text);
                //Atribuindo o sinal
                lblSinal.Text = "/";
                //calculando a divisão
                r = a / b;
                //Mostrando o Resultado
                lblResultado.Text = r.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números!");
            }
        }

        private void btnPotenciação_Click(object sender, EventArgs e)
        {
            double r;
            try
            {
                double a = double.Parse(txtN1.Text);
                double b = double.Parse(txtN2.Text);
                //Atribuindo o sinal
                lblSinal.Text = "^";
                //calculando a potência
                r = Math.Pow(a, b);
                //Mostrando o Resultado
                lblResultado.Text = r.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números!");
            }
        }

        private void btnParImpar_Click(object sender, EventArgs e)
        {
            double r;
            try
            {
                int a = int.Parse(txtN1.Text);
                int b = int.Parse(txtN2.Text);

                //Atribuindo o sinal
                lblSinal.Text = "+-";

                //Verificando se é ímpar ou par
                if(a%2 == 0 && b%2 == 0){
                    lblResultado.Text = "Ambos os números são pares.";
                }
                else if(a%2 == 0 && b%2 != 0)
                {
                    lblResultado.Text = a + " é par e " + b + " é ímpar.";
                }
                else if(a%2 != 0 && b%2 == 0)
                {
                    lblResultado.Text = a + " é ímpar e " + b + " é par.";
                }
                else
                {
                    lblResultado.Text = "Ambos os números são ímpares.";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números!");
            }
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(txtN1.Text);
                double b = double.Parse(txtN2.Text);
                //Atribuindo o sinal
                lblSinal.Text = "<=>";
                //Mostrando o Resultado
                if (a > b) {
                lblResultado.Text = a + " é maior que " + b;
                } else if (b > a)
                {
                    lblResultado.Text = b + " é maior que " + a;
                } else
                {
                    lblResultado.Text ="Os números são iguais.";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números!");
            }
        }
    }
}
