using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int player = 2;
        public int turns = 0;
        public int P1 = 0;
        public int P2 = 0;
        public int pEmpate = 0;

        private void button_click(object sender, EventArgs e)
        {
            Button Button = (Button)sender;
            if (Button.Text == "")
            {
                if (player % 2 == 0)
                {
                    Button.Text = "X";
                    player++;
                    turns++;
                }
                else
                {
                    Button.Text = "O";
                    player++;
                    turns++;
                }
                if (EmpateJogo() == true)
                {
                    MessageBox.Show("Empate");
                    pEmpate++;
                    NovoJogo();
                }
                if (VencedorGame() == true)
                {
                    if (Button.Text == "X")
                    {
                        MessageBox.Show("Jogador X Ganhou");
                        P1++;
                        NovoJogo();
                    }
                    else
                    {
                        MessageBox.Show("Jogador O Ganhou");
                        P2++;
                        NovoJogo();
                    }
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VitoriaX.Text = "X : " + P1;
            VitoriaO.Text = "O :" + P2;
            Empate.Text = "Empate : " + pEmpate;
        }

        void NovoJogo()
        {
            btn1.Text = btn2.Text = btn3.Text = btn4.Text = btn5.Text = btn6.Text = btn7.Text = btn8.Text = btn9.Text = "";
            VitoriaX.Text = "X : " + P1;
            VitoriaO.Text = "O :" + P2;
            Empate.Text = "Empate : " + pEmpate;
            turns = 0;
        }
        void PlacarLimpo(){
            VitoriaO.Text = "";
            VitoriaX.Text = "";
            Empate.Text = "";
            turns = 0;
        }
       


        private void btnNewGame_Click(object sender, EventArgs e)
        {
            NovoJogo();
        }

        bool EmpateJogo()
        {
            if (turns == 9)
            {
                return true;
                
            }
            else
            {
                return false;
            }
        }

        bool VencedorGame()
        {
            //vertical
            if((btn1.Text==btn4.Text)&&(btn4.Text==btn7.Text) && btn1.Text != "")
            {
                return true;
            }
            else if ((btn2.Text == btn5.Text) && (btn5.Text == btn8.Text) && btn2.Text != "")
            {
                return true;
            }
            else if ((btn3.Text == btn6.Text) && (btn6.Text == btn9.Text) && btn3.Text != "")
            {
                return true;
            }
            //Horizontal

            if ((btn1.Text == btn2.Text) && (btn2.Text == btn3.Text) && btn1.Text != ""){
                return true;
            }
            else if ((btn4.Text == btn5.Text) && (btn5.Text == btn6.Text) && btn4.Text != "")
            {
                return true;
            }
            else if ((btn7.Text == btn8.Text) && (btn8.Text == btn9.Text) && btn7.Text != "")
            {
                return true;
            }

            //Diagonal

            if ((btn1.Text == btn5.Text) && (btn5.Text == btn9.Text) && btn1.Text != "")
            {
                return true;
            }
            else if ((btn3.Text == btn5.Text) && (btn5.Text == btn7.Text) && btn3.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            NovoJogo();
            PlacarLimpo();
        }
    }
}
