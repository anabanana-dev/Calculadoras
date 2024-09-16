
namespace WF_Projeto_Cálculos
{
    partial class frmCalculosBotões
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSinal = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnSomar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnParImpar = new System.Windows.Forms.Button();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnPotenciação = new System.Windows.Forms.Button();
            this.btnComparar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtN2
            // 
            this.txtN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN2.Location = new System.Drawing.Point(303, 167);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(282, 32);
            this.txtN2.TabIndex = 2;
            this.txtN2.TextAlignChanged += new System.EventHandler(this.txtN1_TextAlignChanged);
            this.txtN2.TextChanged += new System.EventHandler(this.txtN2_TextChanged);
            // 
            // txtN1
            // 
            this.txtN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN1.Location = new System.Drawing.Point(303, 103);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(282, 32);
            this.txtN1.TabIndex = 1;
            this.txtN1.TextAlignChanged += new System.EventHandler(this.txtN1_TextAlignChanged);
            this.txtN1.TextChanged += new System.EventHandler(this.txtN1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(219, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "_______________________________";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSinal
            // 
            this.lblSinal.AutoSize = true;
            this.lblSinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinal.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblSinal.Location = new System.Drawing.Point(224, 136);
            this.lblSinal.Name = "lblSinal";
            this.lblSinal.Size = new System.Drawing.Size(34, 34);
            this.lblSinal.TabIndex = 3;
            this.lblSinal.Text = "?";
            this.lblSinal.Click += new System.EventHandler(this.lblSinal_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblResultado.Location = new System.Drawing.Point(219, 240);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblResultado.Size = new System.Drawing.Size(415, 36);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "?";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // btnSomar
            // 
            this.btnSomar.BackColor = System.Drawing.SystemColors.Control;
            this.btnSomar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnSomar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSomar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSomar.Location = new System.Drawing.Point(67, 306);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(168, 43);
            this.btnSomar.TabIndex = 3;
            this.btnSomar.Text = "&Somar";
            this.btnSomar.UseVisualStyleBackColor = false;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnLimpar.Location = new System.Drawing.Point(268, 463);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(168, 43);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.SystemColors.Control;
            this.btnFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnFechar.Location = new System.Drawing.Point(462, 463);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(168, 43);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.Text = "&Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnParImpar
            // 
            this.btnParImpar.BackColor = System.Drawing.SystemColors.Control;
            this.btnParImpar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnParImpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParImpar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnParImpar.Location = new System.Drawing.Point(67, 370);
            this.btnParImpar.Name = "btnParImpar";
            this.btnParImpar.Size = new System.Drawing.Size(168, 43);
            this.btnParImpar.TabIndex = 6;
            this.btnParImpar.Text = "P&ar ímpar";
            this.btnParImpar.UseVisualStyleBackColor = false;
            this.btnParImpar.Click += new System.EventHandler(this.btnParImpar_Click);
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.BackColor = System.Drawing.SystemColors.Control;
            this.btnSubtrair.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnSubtrair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtrair.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSubtrair.Location = new System.Drawing.Point(268, 306);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(168, 43);
            this.btnSubtrair.TabIndex = 7;
            this.btnSubtrair.Text = "S&ubtrair";
            this.btnSubtrair.UseVisualStyleBackColor = false;
            this.btnSubtrair.Click += new System.EventHandler(this.btnSubtrair_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.BackColor = System.Drawing.SystemColors.Control;
            this.btnMultiplicar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnMultiplicar.Location = new System.Drawing.Point(462, 306);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(168, 43);
            this.btnMultiplicar.TabIndex = 8;
            this.btnMultiplicar.Text = "&Multiplicar";
            this.btnMultiplicar.UseVisualStyleBackColor = false;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.BackColor = System.Drawing.SystemColors.Control;
            this.btnDividir.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDividir.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnDividir.Location = new System.Drawing.Point(268, 370);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(168, 43);
            this.btnDividir.TabIndex = 9;
            this.btnDividir.Text = "&Dividir";
            this.btnDividir.UseVisualStyleBackColor = false;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btnPotenciação
            // 
            this.btnPotenciação.BackColor = System.Drawing.SystemColors.Control;
            this.btnPotenciação.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnPotenciação.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPotenciação.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnPotenciação.Location = new System.Drawing.Point(462, 370);
            this.btnPotenciação.Name = "btnPotenciação";
            this.btnPotenciação.Size = new System.Drawing.Size(168, 43);
            this.btnPotenciação.TabIndex = 10;
            this.btnPotenciação.Text = "&Potenciação";
            this.btnPotenciação.UseVisualStyleBackColor = false;
            this.btnPotenciação.Click += new System.EventHandler(this.btnPotenciação_Click);
            // 
            // btnComparar
            // 
            this.btnComparar.BackColor = System.Drawing.SystemColors.Control;
            this.btnComparar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnComparar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComparar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnComparar.Location = new System.Drawing.Point(650, 330);
            this.btnComparar.Name = "btnComparar";
            this.btnComparar.Size = new System.Drawing.Size(168, 61);
            this.btnComparar.TabIndex = 11;
            this.btnComparar.Text = "&Comparar";
            this.btnComparar.UseVisualStyleBackColor = false;
            this.btnComparar.Click += new System.EventHandler(this.btnComparar_Click);
            // 
            // frmCalculosBotões
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.CancelButton = this.btnFechar;
            this.ClientSize = new System.Drawing.Size(876, 602);
            this.Controls.Add(this.btnComparar);
            this.Controls.Add(this.btnPotenciação);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.btnParImpar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblSinal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.txtN2);
            this.Name = "frmCalculosBotões";
            this.Text = "Cálculos com Botões";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSinal;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnParImpar;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnPotenciação;
        private System.Windows.Forms.Button btnComparar;
    }
}

