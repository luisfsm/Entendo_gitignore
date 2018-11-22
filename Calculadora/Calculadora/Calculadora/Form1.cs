using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        Double Resultado = 0;
        String Operador ="";
        bool OperadorUso = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_numeros(object sender, EventArgs e)
        {
            if ((txtResultado.Text == "0") || (OperadorUso) || (txtResultado.TextLength >= 13))
                txtResultado.Clear();
  
            OperadorUso = false;
            Button numeros = (Button)sender;
            if (numeros.Text == ","){
                if (!txtResultado.Text.Contains(",")){
                    txtResultado.Text += numeros.Text;
                }
            }
            else
            {
                txtResultado.Text +=  numeros.Text;
            }

     
      
        }

        private void Btn_operador(object sender, EventArgs e)
        {
            Button operador = (Button)sender;
            Operador = operador.Text;
            Resultado = Convert.ToDouble(txtResultado.Text);
            lblConta.Text = Resultado +" "+ operador.Text;
            OperadorUso = true;
        }

        private void BtnIgual(object sender, EventArgs e)
        {
            switch (Operador){

                case "+":
                    txtResultado.Text = (Resultado + Double.Parse(txtResultado.Text)).ToString();
                break;
                case "/":
                    txtResultado.Text = (Resultado / Double.Parse(txtResultado.Text)).ToString();
                break;
                case "-":
                    txtResultado.Text = (Resultado - Double.Parse(txtResultado.Text)).ToString();
                break;
                case "X":
                    txtResultado.Text = (Resultado * Double.Parse(txtResultado.Text)).ToString();
                break;
                default:

                break;
            }
            Resultado = Double.Parse(txtResultado.Text);
            lblConta.Text ="";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "0";
            lblConta.Text = "";
        }

        private void btn_limpachar(object sender, EventArgs e)
        {
            Button Limpar = (Button)sender;
            
        }
    }
}
