namespace WindowsFormsApp1
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
            this.imgVoto = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCandidato = new System.Windows.Forms.Label();
            this.lblPartido = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.val1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgVoto)).BeginInit();
            this.SuspendLayout();
            // 
            // imgVoto
            // 
            this.imgVoto.Location = new System.Drawing.Point(38, 27);
            this.imgVoto.Name = "imgVoto";
            this.imgVoto.Size = new System.Drawing.Size(152, 122);
            this.imgVoto.TabIndex = 0;
            this.imgVoto.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Candidato :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Partido :";
            // 
            // lblCandidato
            // 
            this.lblCandidato.Location = new System.Drawing.Point(113, 249);
            this.lblCandidato.Name = "lblCandidato";
            this.lblCandidato.Size = new System.Drawing.Size(100, 23);
            this.lblCandidato.TabIndex = 4;
            // 
            // lblPartido
            // 
            this.lblPartido.Location = new System.Drawing.Point(113, 289);
            this.lblPartido.Name = "lblPartido";
            this.lblPartido.Size = new System.Drawing.Size(100, 23);
            this.lblPartido.TabIndex = 6;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn1.Location = new System.Drawing.Point(330, 52);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(60, 47);
            this.btn1.TabIndex = 8;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn_enviar);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn2.Location = new System.Drawing.Point(417, 52);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(60, 47);
            this.btn2.TabIndex = 9;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn_enviar);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn3.Location = new System.Drawing.Point(508, 52);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(60, 47);
            this.btn3.TabIndex = 10;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn_enviar);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn4.Location = new System.Drawing.Point(330, 119);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(60, 47);
            this.btn4.TabIndex = 11;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn_enviar);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn5.Location = new System.Drawing.Point(417, 119);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(60, 47);
            this.btn5.TabIndex = 12;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn_enviar);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn6.Location = new System.Drawing.Point(508, 119);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(60, 47);
            this.btn6.TabIndex = 13;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn_enviar);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn7.Location = new System.Drawing.Point(330, 186);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(60, 47);
            this.btn7.TabIndex = 14;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn_enviar);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn8.Location = new System.Drawing.Point(417, 186);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(60, 47);
            this.btn8.TabIndex = 15;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn_enviar);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn9.Location = new System.Drawing.Point(508, 186);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(60, 47);
            this.btn9.TabIndex = 16;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn_enviar);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn0.Location = new System.Drawing.Point(417, 249);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(60, 47);
            this.btn0.TabIndex = 17;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn_enviar);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(499, 332);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(93, 54);
            this.button11.TabIndex = 18;
            this.button11.Text = "button11";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(404, 332);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(89, 54);
            this.button12.TabIndex = 19;
            this.button12.Text = "button12";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(312, 332);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(86, 54);
            this.button13.TabIndex = 20;
            this.button13.Text = "button13";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // val1
            // 
            this.val1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.val1.Location = new System.Drawing.Point(52, 164);
            this.val1.Name = "val1";
            this.val1.Size = new System.Drawing.Size(122, 43);
            this.val1.TabIndex = 21;
            this.val1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 410);
            this.Controls.Add(this.val1);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lblPartido);
            this.Controls.Add(this.lblCandidato);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgVoto);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imgVoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgVoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCandidato;
        private System.Windows.Forms.Label lblPartido;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button val1;
    }
}

