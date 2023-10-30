namespace Imc
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txbPeso = new System.Windows.Forms.TextBox();
            this.txbAltura = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblClassificacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbPeso
            // 
            this.txbPeso.Location = new System.Drawing.Point(93, 97);
            this.txbPeso.Name = "txbPeso";
            this.txbPeso.Size = new System.Drawing.Size(100, 20);
            this.txbPeso.TabIndex = 0;
            this.txbPeso.TextChanged += new System.EventHandler(this.txbPeso_TextChanged);
            this.txbPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPeso_KeyPress);
            // 
            // txbAltura
            // 
            this.txbAltura.Location = new System.Drawing.Point(93, 143);
            this.txbAltura.Name = "txbAltura";
            this.txbAltura.Size = new System.Drawing.Size(100, 20);
            this.txbAltura.TabIndex = 1;
            this.txbAltura.TextChanged += new System.EventHandler(this.txbAltura_TextChanged);
            this.txbAltura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbAltura_KeyPress);
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(40, 104);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(53, 13);
            this.lblPeso.TabIndex = 2;
            this.lblPeso.Text = "Peso(Kg):";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(40, 150);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(52, 13);
            this.lblAltura.TabIndex = 3;
            this.lblAltura.Text = "Altura(M):";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(111, 241);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 4;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(103, 194);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular IMC";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblClassificacao
            // 
            this.lblClassificacao.AutoSize = true;
            this.lblClassificacao.Location = new System.Drawing.Point(93, 282);
            this.lblClassificacao.Name = "lblClassificacao";
            this.lblClassificacao.Size = new System.Drawing.Size(0, 13);
            this.lblClassificacao.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 388);
            this.Controls.Add(this.lblClassificacao);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.txbAltura);
            this.Controls.Add(this.txbPeso);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculadora de IMC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbPeso;
        private System.Windows.Forms.TextBox txbAltura;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblClassificacao;
    }
}

