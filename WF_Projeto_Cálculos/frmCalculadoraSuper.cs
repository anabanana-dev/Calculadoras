using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace WF_Projeto_Cálculos
{
    public partial class frmCalculadoraSuper : Form
    {
        public frmCalculadoraSuper()
        {
            InitializeComponent();
        }
        //Variáveis globais
        double vNumAnt;
        string vOperacao;
        bool vLimpa;
        Color corant;

        Button but = new Button();
        private void frmCalculadoraSuper_KeyDown(object sender, KeyEventArgs e)
        {
            label1.Text = e.KeyCode.ToString();

            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }

            string tecla = e.KeyCode.ToString();

            foreach (Button but in panel1.Controls)
            {
                if ((but is Button) && tecla.Length == 7)
                {
                    if (but.Text == tecla.Substring(6, 1))
                    {
                        corant = but.BackColor;
                        but.BackColor = Color.Brown;
                    }
                }
                if ((but is Button) && tecla.Length == 2)
                {
                    if (but.Text == tecla.Substring(1, 1))
                    {
                        corant = but.BackColor;
                        but.BackColor = Color.Brown;
                    }
                }
            }
            foreach (Button but in panel2.Controls)
            {
                if ((but is Button) && e.KeyCode.ToString() == "Add")
                {
                    if (but.Text == "+")
                    {
                        corant = but.BackColor;
                        but.BackColor = Color.Brown;
                    }
                }
                if ((but is Button) && e.KeyCode.ToString() == "Subtract")
                {
                    if (but.Text == "-")
                    {
                        corant = but.BackColor;
                        but.BackColor = Color.Brown;
                    }
                }
                if ((but is Button) && e.KeyCode.ToString() == "Multiply")
                {
                    if (but.Text == "x")
                    {
                        corant = but.BackColor;
                        but.BackColor = Color.Brown;
                    }
                }
                if ((but is Button) && e.KeyCode.ToString() == "Divide")
                {
                    if (but.Text == ":")
                    {
                        corant = but.BackColor;
                        but.BackColor = Color.Brown;
                    }
                }
                if ((but is Button) && e.KeyCode.ToString() == "Oemcomma")
                {
                    if (but.Text == ",")
                    {
                        corant = but.BackColor;
                        but.BackColor = Color.Brown;
                    }
                }
                if ((but is Button) && e.KeyCode.ToString() == "P")
                {
                    if (but.Text == "^")
                    {
                        corant = but.BackColor;
                        but.BackColor = Color.Brown;
                    }
                }
                if ((but is Button) && e.KeyCode.ToString() == "Return")
                {
                    if (but.Text == "=")
                    {
                        corant = but.BackColor;
                        but.BackColor = Color.Brown;
                    }
                }
            }
            if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
            {
                but.Text = tecla.Substring(6, 1);
                f_Numeros(but, e);
            }
            else if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            {
                but.Text = tecla.Substring(1, 1);
                f_Numeros(but, e);
            }
            else
            {
                switch (e.KeyCode.ToString())
                {
                    case "Add":
                        {
                            but.Text = "+";
                            f_Operacoes(but, e);
                            break;
                        }
                    case "Subtract":
                        {
                            but.Text = "-";
                            f_Operacoes(but, e);
                            break;
                        }
                    case "Multiply":
                        {
                            but.Text = "x";
                            f_Operacoes(but, e);
                            break;
                        }
                    case "Divide":
                        {
                            but.Text = ":";
                            f_Operacoes(but, e);
                            break;
                        }
                    case "Oemcomma":
                        {
                            but.Text = ",";
                            f_Numeros(but, e);
                            break;
                        }
                    case "P":
                        {
                            but.Text = "^";
                            f_Operacoes(but, e);
                            break;
                        }
                    case "Return":
                        {
                            btnIgual_Click(sender, e);
                            break;
                        }
                    case "Back":
                        {
                            btnBack_Click(sender, e);
                            break;
                        }
                    case "End":
                        {
                            btnC_Click(sender, e);
                            break;
                        }
                    case "Delete":
                        {
                            btnCE_Click(sender, e);
                            break;
                        }
                }
            }

        }
        public void f_Numeros(object sender, EventArgs e)
        {
            if (vLimpa)
            {
                lblVisor.Text = "";
                vLimpa = false;
            }
            if (lblVisor.Text == "0" && ((Button)sender).Text != ",")
            { 
                lblVisor.Text = "";
            }
            if (((Button)sender).Text != "," || 
                (((Button)sender).Text == "," && 
                lblVisor.Text.Contains (",") == false)) //!lblVisor.Text.Contains(",") também funciona
            {
                lblVisor.Text += ((Button)sender).Text;
            }
            lblVisor.Focus(); 
        }
        public void f_Operacoes(object sender, EventArgs e)
        {
            vNumAnt = double.Parse(lblVisor.Text);
            vOperacao = ((Button)sender).Text;
            vLimpa = true;
            lblVisor.Focus();
            if (lblHistorico.Text == "")
            {
                lblHistorico.Text += vNumAnt + " " + vOperacao + " ";
            }
            else 
            { 
                lblHistorico.Text = "";
                lblHistorico.Text += vNumAnt + " " + vOperacao + " ";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblVisor_Click(object sender, EventArgs e)
        {

        }

        private void frmCalculadoraSuper_Load(object sender, EventArgs e)
        {

        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            double vNumAtual = double.Parse(lblVisor.Text);

            if (lblHistorico.Text.Contains("=") == false)
            {
                switch (vOperacao)
                {
                    case "+":
                        {
                            lblVisor.Text = (vNumAnt + vNumAtual).ToString();
                            double calc = (vNumAnt + vNumAtual);
                            lblHistorico.Text += vNumAtual + " = " + calc;
                            break;
                        }
                    case "-":
                        {
                            lblVisor.Text = (vNumAnt - vNumAtual).ToString();
                            double calc = (vNumAnt - vNumAtual);
                            lblHistorico.Text += vNumAtual + " = " + calc;
                            break;
                        }
                    case "x":
                        {
                            lblVisor.Text = (vNumAnt * vNumAtual).ToString();
                            double calc = (vNumAnt * vNumAtual);
                            lblHistorico.Text += vNumAtual + " = " + calc;
                            break;
                        }
                    case ":":
                        {
                            lblVisor.Text = (vNumAnt / vNumAtual).ToString();
                            double calc = (vNumAnt / vNumAtual);
                            lblHistorico.Text += vNumAtual + " = " + calc;
                            break;

                        }
                    case "^":
                        {
                            lblVisor.Text = Math.Pow(vNumAnt, vNumAtual).ToString();
                            double calc = Math.Pow(vNumAnt, vNumAtual);
                            lblHistorico.Text += vNumAtual + " = " + calc;
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
            else { lblHistorico.Text = ""; }
            vLimpa = true;
            vNumAnt = 0;
            vNumAtual = 0;
        }

        private void btnInverte_Click(object sender, EventArgs e)
        {
            lblVisor.Text = (decimal.Parse(lblVisor.Text) * -1).ToString();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            lblVisor.Text = lblVisor.Text.Substring(0,lblVisor.Text.Length - 1);
            if (lblVisor.Text == "")
            {
                lblVisor.Text = "0";
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            lblVisor.Text = "0";
            lblHistorico.Text = "";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            lblVisor.Text = "0";
        }
        private void frmCalculadoraSuper_KeyUp(object sender, KeyEventArgs e)
        {
             string tecla = e.KeyCode.ToString();

            foreach(Button but in panel1.Controls)
            {
                if((but is Button) && tecla.Length == 7)
                {
                    if(but.Text == tecla.Substring(6, 1))
                    {
                        but.BackColor = corant;
                    }
                }
                if ((but is Button) && tecla.Length == 2)
                {
                    if (but.Text == tecla.Substring(1, 1))
                    {
                        but.BackColor = corant;
                    }
                }
            }
            foreach (Button but in panel2.Controls)
            {
                if ((but is Button) && e.KeyCode.ToString() == "Add")
                {
                    if (but.Text == "+")
                    {
                        but.BackColor = corant;
                    }
                }
                if ((but is Button) && e.KeyCode.ToString() == "Subtract")
                {
                    if (but.Text == "-")
                    {
                        but.BackColor = corant;
                    }
                }
                if ((but is Button) && e.KeyCode.ToString() == "Multiply")
                {
                    if (but.Text == "x")
                    {
                        but.BackColor = corant;
                    }
                }
                if ((but is Button) && e.KeyCode.ToString() == "Divide")
                {
                    if (but.Text == ":")
                    {
                        but.BackColor = corant;
                    }
                }
                if ((but is Button) && e.KeyCode.ToString() == "Oemcomma")
                {
                    if (but.Text == ",")
                    {
                        but.BackColor = corant;
                    }
                }
                if ((but is Button) && e.KeyCode.ToString() == "P")
                {
                    if (but.Text == "^")
                    {
                        but.BackColor = corant;
                    }
                }
                if ((but is Button) && e.KeyCode.ToString() == "Return")
                {
                    if (but.Text == "=")
                    {
                        but.BackColor = corant;
                    }
                }
            }
        }
    }
}
