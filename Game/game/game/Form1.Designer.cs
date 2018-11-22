namespace game
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
            this.btn1 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.Empate = new System.Windows.Forms.Label();
            this.VitoriaX = new System.Windows.Forms.Label();
            this.VitoriaO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(3, 12);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(92, 89);
            this.btn1.TabIndex = 0;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button_click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(3, 107);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(92, 89);
            this.btn4.TabIndex = 1;
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.button_click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(3, 202);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(92, 89);
            this.btn7.TabIndex = 2;
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.button_click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(101, 202);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(92, 89);
            this.btn8.TabIndex = 5;
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.button_click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(101, 107);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(92, 89);
            this.btn5.TabIndex = 4;
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.button_click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(101, 12);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(92, 89);
            this.btn2.TabIndex = 3;
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.button_click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(199, 202);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(92, 89);
            this.btn9.TabIndex = 8;
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.button_click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(199, 107);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(92, 89);
            this.btn6.TabIndex = 7;
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.button_click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(199, 12);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(92, 89);
            this.btn3.TabIndex = 6;
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.button_click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(3, 308);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(111, 36);
            this.btnNewGame.TabIndex = 9;
            this.btnNewGame.Text = "Novo Jogo";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(120, 308);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(111, 36);
            this.btnReiniciar.TabIndex = 10;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(272, 308);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(111, 36);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Empate
            // 
            this.Empate.Location = new System.Drawing.Point(297, 30);
            this.Empate.Name = "Empate";
            this.Empate.Size = new System.Drawing.Size(100, 23);
            this.Empate.TabIndex = 12;
            this.Empate.Text = "label1";
            // 
            // VitoriaX
            // 
            this.VitoriaX.Location = new System.Drawing.Point(297, 68);
            this.VitoriaX.Name = "VitoriaX";
            this.VitoriaX.Size = new System.Drawing.Size(100, 23);
            this.VitoriaX.TabIndex = 13;
            this.VitoriaX.Text = "label2";
            // 
            // VitoriaO
            // 
            this.VitoriaO.Location = new System.Drawing.Point(297, 104);
            this.VitoriaO.Name = "VitoriaO";
            this.VitoriaO.Size = new System.Drawing.Size(100, 23);
            this.VitoriaO.TabIndex = 14;
            this.VitoriaO.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 356);
            this.Controls.Add(this.VitoriaO);
            this.Controls.Add(this.VitoriaX);
            this.Controls.Add(this.Empate);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Jogo Da Velha";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label Empate;
        private System.Windows.Forms.Label VitoriaX;
        private System.Windows.Forms.Label VitoriaO;
    }
}

