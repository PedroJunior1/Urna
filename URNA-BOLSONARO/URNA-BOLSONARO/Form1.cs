using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace URNA_BOLSONARO
{
    public partial class UrnaEletrônica : Form
    {
        string voto;
        int Bolso, Haddad, Ciro, Daciolo, Alk, Nulo, Branco;



        public UrnaEletrônica()
        {
            InitializeComponent();
        }

        private void UrnaEletrônica_Load(object sender, EventArgs e)
        {

        }

        private void btnNulo_Click(object sender, EventArgs e)
        {
            Branco++; lblBranco.Text = "Branco:" + Branco.ToString();
        }

        private void ButtonClass(object sender, EventArgs e)
        {
            Button x = (Button)sender;
            textBox1.Text = textBox1.Text + x.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        

            {

            }

            private void btnCorrige_Click(object sender, EventArgs e)
            {
                textBox1.Text = "";
                pbxCandidato.Image = null;
            }

            private void btnConfirma_Click(object sender, EventArgs e)
            {
                voto = textBox1.Text;
                switch (voto)
                {
                    case "13":
                        pbxCandidato.Load("Haddad.jpg");
                        Haddad++; lblHadda.Text = "Haddad:" + Haddad.ToString(); break;

                    break;
                    case "45":
                        pbxCandidato.Load("Alk.jpg");
                        Alk++; lblAlk.Text = "Alckmim:" + Alk.ToString(); break;

                    break;
                    case "17":
                        pbxCandidato.Load("Bolso.jpg");
                        Bolso++; lblBolso.Text = "Bolsonaro:" + Bolso.ToString(); break;

                    break;
                    case "12":
                        pbxCandidato.Load("Ciro.jpg");
                        Ciro++; lblCiro.Text = "Ciro:" + Ciro.ToString(); break;

                    break;
                    case "51":
                        pbxCandidato.Load("Cabo.jpg");
                        Daciolo++; lblDaci.Text = "Daciolo:" + Daciolo.ToString(); break;

                    default:
                        Nulo++; lblNulo.Text = "Nulo:" + Nulo.ToString();


                    break;
                }
            }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}