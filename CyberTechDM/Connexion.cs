using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberTechDM
{
    public partial class Connexion : Form
    {
        Functions Con;
        public Connexion()
        {
            InitializeComponent();
            Con = new Functions();
        }
        //Permet de garder les infos lors de la connexion a une session
        public static int UserId;
        public static string UserName;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ConBtn_Click(object sender, EventArgs e)
        {
            if (NomTb.Text == "" || MPasseTb.Text == "")
            {
                MessageBox.Show("Entrez des informations valides");
            }
            else if (NomTb.Text == "Admin" && MPasseTb.Text == "Admin")
            {
                //Accès à article autorisé pour l'Admin
                Articles Obj = new Articles();
                Obj.Show();
                this.Hide();
            }
            else
            {
                string Req = "Select * from Vendeur where VendPseudo = '{0}' and VendPass = '{1}'";
                Req = string.Format(Req, NomTb.Text, MPasseTb.Text);
                DataTable dt = Con.RecupererDonnees(Req);
                if(dt.Rows.Count == 0) 
                {
                    MessageBox.Show("Vendeur Inexistant");
                }
                else
                {
                    //Pour affichage du nom dans facture lors de la connexion a la session
                    UserName = "Connecter en tant que : " + (dt.Rows[0][2].ToString());
                    UserId = Convert.ToInt32(dt.Rows[0][0].ToString());
                    //Accès à facture autorisé si Vendeur existant
                    Factures Obj = new Factures();
                    Obj.Show();
                    this.Hide();
                }
            }
        }

        private void NomTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Vous etes sur de fermer l'application ?", "Exit message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
} 
