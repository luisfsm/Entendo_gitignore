using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string candidato;
        private void btn_enviar(object sender, EventArgs e)
        {
            Button Numeros = (Button)sender;

            if ((val1.Text.Length <= 1) ||( val1.Text.Length ==2))
            {
                val1.Text += Numeros.Text;
                candidato = val1.Text;
            }

            switch (candidato)
            {
                case "51" :
                    lblCandidato.Text = "Cabo Daciolo";
                    lblPartido.Text = "PATRIOTA";

                break;
                case "13" :
                    lblCandidato.Text = "Fernando Haddad";
                    lblPartido.Text = "PT";


                break;
                case "40":
                    lblCandidato.Text = "Geraldo Alckmin";
                    lblPartido.Text = "PSDB";


                break;
                case "17":

                    lblCandidato.Text = "Jair Bolsonaro";
                    lblPartido.Text = "PSL";
                break;
                case "" :
                    lblCandidato.Text = "Nulo";
                    lblPartido.Text = "Nulo";
                break;
                default:
                    lblCandidato.Text = "Nulo";
                    lblPartido.Text = "Nulo";
                 break;
                 
            }

        }

    }
}
