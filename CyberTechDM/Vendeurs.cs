using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CyberTechDM
{
    public partial class Vendeurs : Form
    {
        Functions Con;
        public Vendeurs()
        {
            InitializeComponent();
            Con = new Functions();
            ListerVendeurs();
        }
        private void ListerVendeurs()
        {
            string Req = "Select * from Vendeur";
            VendeursListe.DataSource = Con.RecupererDonnees(Req);
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CategoriesListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //Permet d'intégrer les informations dans les zones lors du clic
        int Key = 0;
        private void CategoriesListe_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            NomTb.Text = VendeursListe.SelectedRows[0].Cells[1].Value.ToString();
            PseudoTb.Text = VendeursListe.SelectedRows[0].Cells[2].Value.ToString();
            MdpTb.Text = VendeursListe.SelectedRows[0].Cells[3].Value.ToString();
            TelTb.Text = VendeursListe.SelectedRows[0].Cells[4].Value.ToString();
            AdresseTb.Text = VendeursListe.SelectedRows[0].Cells[5].Value.ToString();
            if (NomTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(VendeursListe.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void AjouterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (NomTb.Text == "" || PseudoTb.Text == "" || MdpTb.Text == "" || TelTb.Text == "" ||AdresseTb.Text == "")
                {
                    MessageBox.Show("Completer le formulaire svp !");
                }
                else
                {
                    String Nom = NomTb.Text;
                    String Pseudo = PseudoTb.Text;
                    String MotDePasse = MdpTb.Text;
                    String Telephone = TelTb.Text;
                    String Adresse = AdresseTb.Text;
                    string Req = "insert into Vendeur values('{0}','{1}','{2}',{3},'{4}')";
                    Req = string.Format(Req, Nom, Pseudo, MotDePasse, Telephone, Adresse);
                    Con.EnvoyerDonnees(Req);
                    ListerVendeurs();
                    MessageBox.Show("Vendeur Ajouté !");
                    NomTb.Text = "";
                    PseudoTb.Text = "";
                    MdpTb.Text = "";
                    TelTb.Text = "";
                    AdresseTb.Text = "";

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void MdpTb_TextChanged(object sender, EventArgs e)
        {
            MdpTb.PasswordChar = '*';
        }

        private void SupprimerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Key == 0)
                {
                    MessageBox.Show("Selectionnez un Vendeur !");
                }
                else
                {
                    String Nom = NomTb.Text;
                    String Pseudo = PseudoTb.Text;
                    String MotDePasse = MdpTb.Text;
                    String Telephone = TelTb.Text;
                    String Adresse = AdresseTb.Text;
                    string Req = "delete from Vendeur where VendCode = {0}";
                    Req = string.Format(Req, Key);
                    Con.EnvoyerDonnees(Req);
                    ListerVendeurs();
                    MessageBox.Show("Vendeur Supprimer !");
                    NomTb.Text = "";
                    PseudoTb.Text = "";
                    MdpTb.Text = "";
                    TelTb.Text = "";
                    AdresseTb.Text = "";

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void ModifierBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (NomTb.Text == "" || PseudoTb.Text == "" || MdpTb.Text == "" || TelTb.Text == "" || AdresseTb.Text == "")
                {
                    MessageBox.Show("Completer le formulaire svp !");
                }
                else
                {
                    String Nom = NomTb.Text;
                    String Pseudo = PseudoTb.Text;
                    String MotDePasse = MdpTb.Text;
                    String Telephone = TelTb.Text;
                    String Adresse = AdresseTb.Text;
                    string Req = "update Vendeur set VendNom = '{0}', VendPseudo = '{1}', VendPass = '{2}', VendPhone = '{3}', VendAdd = '{4}' where VendCode = {5}";
                    Req = string.Format(Req, Nom, Pseudo, MotDePasse, Telephone, Adresse, Key);
                    Con.EnvoyerDonnees(Req);
                    ListerVendeurs();
                    MessageBox.Show("Vendeur Modifié !");
                    NomTb.Text = "";
                    PseudoTb.Text = "";
                    MdpTb.Text = "";
                    TelTb.Text = "";
                    AdresseTb.Text = "";

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Articles Obj = new Articles();
            Obj.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Categories Obj = new Categories();
            Obj.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Vendeurs Obj = new Vendeurs();
            Obj.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Factures Obj = new Factures();
            Obj.Show();
            this.Hide();
        }

        private void DeconnLbl_Click(object sender, EventArgs e)
        {
            Connexion Obj = new Connexion();
            Obj.Show();
            this.Hide();
        }      

        

      
    }
}
