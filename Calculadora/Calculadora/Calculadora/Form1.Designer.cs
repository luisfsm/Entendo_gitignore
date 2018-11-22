namespace Calculadora
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
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnUm = new System.Windows.Forms.Button();
            this.btnQuatro = new System.Windows.Forms.Button();
            this.btnSete = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnOito = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnDois = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btnNove = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnMais = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.lblConta = new System.Windows.Forms.Label();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(24, 50);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(263, 27);
            this.txtResultado.TabIndex = 0;
            this.txtResultado.Text = "0";
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnUm
            // 
            this.btnUm.Location = new System.Drawing.Point(24, 152);
            this.btnUm.Name = "btnUm";
            this.btnUm.Size = new System.Drawing.Size(48, 38);
            this.btnUm.TabIndex = 1;
            this.btnUm.Text = "1";
            this.btnUm.UseVisualStyleBackColor = true;
            this.btnUm.Click += new System.EventHandler(this.Btn_numeros);
            // 
            // btnQuatro
            // 
            this.btnQuatro.Location = new System.Drawing.Point(24, 196);
            this.btnQuatro.Name = "btnQuatro";
            this.btnQuatro.Size = new System.Drawing.Size(48, 38);
            this.btnQuatro.TabIndex = 2;
            this.btnQuatro.Text = "4";
            this.btnQuatro.UseVisualStyleBackColor = true;
            this.btnQuatro.Click += new System.EventHandler(this.Btn_numeros);
            // 
            // btnSete
            // 
            this.btnSete.Location = new System.Drawing.Point(24, 240);
            this.btnSete.Name = "btnSete";
            this.btnSete.Size = new System.Drawing.Size(48, 38);
            this.btnSete.TabIndex = 3;
            this.btnSete.Text = "7";
            this.btnSete.UseVisualStyleBackColor = true;
            this.btnSete.Click += new System.EventHandler(this.Btn_numeros);
            // 
            // btnCE
            // 
            this.btnCE.Location = new System.Drawing.Point(239, 152);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(48, 38);
            this.btnCE.TabIndex = 4;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(24, 284);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(123, 38);
            this.btnZero.TabIndex = 8;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.Btn_numeros);
            // 
            // btnOito
            // 
            this.btnOito.Location = new System.Drawing.Point(99, 240);
            this.btnOito.Name = "btnOito";
            this.btnOito.Size = new System.Drawing.Size(48, 38);
            this.btnOito.TabIndex = 7;
            this.btnOito.Text = "8";
            this.btnOito.UseVisualStyleBackColor = true;
            this.btnOito.Click += new System.EventHandler(this.Btn_numeros);
            // 
            // btnCinco
            // 
            this.btnCinco.Location = new System.Drawing.Point(99, 196);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(48, 38);
            this.btnCinco.TabIndex = 6;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = true;
            this.btnCinco.Click += new System.EventHandler(this.Btn_numeros);
            // 
            // btnDois
            // 
            this.btnDois.Location = new System.Drawing.Point(99, 152);
            this.btnDois.Name = "btnDois";
            this.btnDois.Size = new System.Drawing.Size(48, 38);
            this.btnDois.TabIndex = 5;
            this.btnDois.Text = "2";
            this.btnDois.UseVisualStyleBackColor = true;
            this.btnDois.Click += new System.EventHandler(this.Btn_numeros);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(170, 284);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(48, 38);
            this.button9.TabIndex = 12;
            this.button9.Text = ",";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Btn_numeros);
            // 
            // btnNove
            // 
            this.btnNove.Location = new System.Drawing.Point(170, 240);
            this.btnNove.Name = "btnNove";
            this.btnNove.Size = new System.Drawing.Size(48, 38);
            this.btnNove.TabIndex = 11;
            this.btnNove.Text = "9";
            this.btnNove.UseVisualStyleBackColor = true;
            this.btnNove.Click += new System.EventHandler(this.Btn_numeros);
            // 
            // btnSeis
            // 
            this.btnSeis.Location = new System.Drawing.Point(170, 196);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(48, 38);
            this.btnSeis.TabIndex = 10;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = true;
            this.btnSeis.Click += new System.EventHandler(this.Btn_numeros);
            // 
            // btnTres
            // 
            this.btnTres.Location = new System.Drawing.Point(170, 152);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(48, 38);
            this.btnTres.TabIndex = 9;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = true;
            this.btnTres.Click += new System.EventHandler(this.Btn_numeros);
            // 
            // btnMulti
            // 
            this.btnMulti.Location = new System.Drawing.Point(239, 99);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(48, 38);
            this.btnMulti.TabIndex = 16;
            this.btnMulti.Text = "X";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.Btn_operador);
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(170, 99);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(48, 38);
            this.btnDividir.TabIndex = 15;
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.Btn_operador);
            // 
            // btnMenos
            // 
            this.btnMenos.Location = new System.Drawing.Point(99, 99);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(48, 38);
            this.btnMenos.TabIndex = 14;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.Btn_operador);
            // 
            // btnMais
            // 
            this.btnMais.Location = new System.Drawing.Point(24, 99);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(48, 38);
            this.btnMais.TabIndex = 13;
            this.btnMais.Text = "+";
            this.btnMais.UseVisualStyleBackColor = true;
            this.btnMais.Click += new System.EventHandler(this.Btn_operador);
            // 
            // btnIgual
            // 
            this.btnIgual.Location = new System.Drawing.Point(239, 240);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(48, 82);
            this.btnIgual.TabIndex = 17;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.BtnIgual);
            // 
            // lblConta
            // 
            this.lblConta.AutoSize = true;
            this.lblConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblConta.Location = new System.Drawing.Point(21, 30);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(0, 17);
            this.lblConta.TabIndex = 18;
            // 
            // btnLimpa
            // 
            this.btnLimpa.Location = new System.Drawing.Point(239, 196);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(48, 38);
            this.btnLimpa.TabIndex = 19;
            this.btnLimpa.Text = "<-";
            this.btnLimpa.UseVisualStyleBackColor = true;
            this.btnLimpa.Click += new System.EventHandler(this.btn_limpachar);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 334);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.lblConta);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btnMais);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.btnNove);
            this.Controls.Add(this.btnSeis);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnOito);
            this.Controls.Add(this.btnCinco);
            this.Controls.Add(this.btnDois);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnSete);
            this.Controls.Add(this.btnQuatro);
            this.Controls.Add(this.btnUm);
            this.Controls.Add(this.txtResultado);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnUm;
        private System.Windows.Forms.Button btnQuatro;
        private System.Windows.Forms.Button btnSete;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnOito;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnDois;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btnNove;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnMais;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Label lblConta;
        private System.Windows.Forms.Button btnLimpa;
    }
}

