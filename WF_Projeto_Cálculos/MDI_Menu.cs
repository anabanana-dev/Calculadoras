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
    public partial class MDI_Menu : Form
    {
        public MDI_Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void MDI_Menu_Load(object sender, EventArgs e)
        {

        }

        private void eeeeToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void comRadiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalcRadio objCalcBot =
                new frmCalcRadio();
            /*objCalcBot.MdiParent = this;*/
            objCalcBot.Show();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {

        }

        private void comBotõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalculosBotões objCalcBot =
                new frmCalculosBotões();
            /*objCalcBot.MdiParent = this;*/
            objCalcBot.Show();
        }

        private void calculadoraSuperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalculadoraSuper objCalcBot =
                new frmCalculadoraSuper();
            /*objCalcBot.MdiParent = this;*/
            objCalcBot.Show();
        }

        private void cálculosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
