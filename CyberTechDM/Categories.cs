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
    public partial class Categories : Form
    {
        Functions Con;
        public Categories()
        {
            InitializeComponent();
            Con = new Functions();
            ListerCategories();
        }
        private void ListerCategories()
        {
            string Req = "Select * from Categorie";
            CategoriesListe.DataSource = Con.RecupererDonnees(Req);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AjouterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(NomTb.Text == "" || RemTb.Text == "")
                {
                    MessageBox.Show("Completer le formulaire svp !");
                }
                else
                {
                    String Nom = NomTb.Text;
                    String Rem = RemTb.Text;
                    string Req = "insert into Categorie values('{0}', '{1}')";
                    Req = string.Format(Req, Nom, Rem);
                    Con.EnvoyerDonnees(Req);
                    ListerCategories();
                    MessageBox.Show("Catégorie Ajoutée !");
                    NomTb.Text = "";
                    RemTb.Text = "";
                }
            }
            catch (Exception Ex) 
            {
                MessageBox.Show(Ex.Message);
            }
        }
        //Permet d'intégrer les informations dans les zones lors du clic
        int Key = 0;
        private void CategoriesListe_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            NomTb.Text = CategoriesListe.SelectedRows[0].Cells[1].Value.ToString();
            RemTb.Text = CategoriesListe.SelectedRows[0].Cells[2].Value.ToString();
            if (NomTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(CategoriesListe.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void ModifierBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (NomTb.Text == "" || RemTb.Text == "")
                {
                    MessageBox.Show("Completer le formulaire svp !");
                }
                else
                {
                    string Nom = NomTb.Text;
                    string Rem = RemTb.Text;
                    string Req = "update Categorie set CatNom = '{0}',CatRem = '{1}' where CatCode = {2}";
                    Req = string.Format(Req, Nom, Rem,Key);
                    Con.EnvoyerDonnees(Req);
                    ListerCategories();
                    MessageBox.Show("Catégorie Modifié !");
                    NomTb.Text = "";
                    RemTb.Text = "";
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void SupprimerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (NomTb.Text == "" || RemTb.Text == "")
                {
                    MessageBox.Show("Completer le formulaire svp !");
                }
                else
                {
                    String Nom = NomTb.Text;
                    String Rem = RemTb.Text;
                    string Req = "delete from Categorie where CatCode = {0}";
                    Req = string.Format(Req,Key);
                    Con.EnvoyerDonnees(Req);
                    ListerCategories();
                    MessageBox.Show("Catégorie Suprimee !");
                    NomTb.Text = "";
                    RemTb.Text = "";
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

        private void label11_Click(object sender, EventArgs e)
        {
            Connexion Obj = new Connexion();
            Obj.Show();
            this.Hide();
        }
    }
}
