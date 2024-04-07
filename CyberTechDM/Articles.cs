using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace CyberTechDM
{
    public partial class Articles : Form
    {
        Functions Con;
        public Articles()
        {
            InitializeComponent();
            Con = new Functions();
            ListerArticles();
            RemplirCategories();
        }
        private void ListerArticles()
        {
            //Récupère tous dans article et affiche dans ArticleListe
            string Req = "Select * from Article";
            ArticlesListe.DataSource = Con.RecupererDonnees(Req);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        //filtre les articles en fonction de la catégorie sélectionnée
        private void Filtrage()
        {
            string Req = "Select * from Article where ArtCat = {0}";
            int Cat = Convert.ToInt32(FiltrerCb.SelectedValue.ToString());
            Req = string.Format(Req, Cat);
            ArticlesListe.DataSource = Con.RecupererDonnees(Req);
        }
        // méthode pour remplir ComboBox (CatCb,FiltrerCb) avec des catégories provenant de la table Categorie
        private void RemplirCategories()
        {
            string Req = "select * from Categorie";
            CatCb.DisplayMember = Con.RecupererDonnees(Req).Columns["CatNom"].ToString();
            CatCb.ValueMember = Con.RecupererDonnees(Req).Columns["CatCode"].ToString();
            CatCb.DataSource = Con.RecupererDonnees(Req);
            FiltrerCb.DisplayMember = Con.RecupererDonnees(Req).Columns["CatNom"].ToString();
            FiltrerCb.ValueMember = Con.RecupererDonnees(Req).Columns["CatCode"].ToString();
            FiltrerCb.DataSource = Con.RecupererDonnees(Req);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (NomTb.Text == "" || PrixTb.Text == "" || CatCb.SelectedIndex  == -1 || StockTb.Text =="")
                {
                    MessageBox.Show("Completer le formulaire svp !");
                }
                else
                {
                    String Nom = NomTb.Text;
                    int Prix = Convert.ToInt32(PrixTb.Text);
                    int Categorie = Convert.ToInt32(CatCb.SelectedValue.ToString());
                    int Stock = Convert.ToInt32(StockTb.Text);
                    string ExpDate = ExpTb.Value.Date.ToString();
                    string Req = "insert into Article values('{0}',{1},{2},{3},'{4}')";
                    Req = string.Format(Req, Nom, Prix, Categorie, Stock, ExpDate);
                    Con.EnvoyerDonnees(Req);
                    ListerArticles();
                    MessageBox.Show("Article Ajoutée !");
                    NomTb.Text = "";
                    PrixTb.Text = "";
                    StockTb.Text = "";
                    CatCb.SelectedIndex = -1;

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (NomTb.Text == "" || PrixTb.Text == "" || CatCb.SelectedIndex == -1 || StockTb.Text == "")
                {
                    MessageBox.Show("Completer le formulaire svp !");
                }
                else
                {
                    String Nom = NomTb.Text;
                    int Prix = Convert.ToInt32(PrixTb.Text);

                    int Categorie = Convert.ToInt32(CatCb.SelectedValue.ToString());
                    int Stock = Convert.ToInt32(StockTb.Text);

                    string ExpDate = ExpTb.Value.Date.ToString();
                    string Req = "Update Article set  ArtNom = '{0}', ArtPrix = {1}, ArtStock = {2}, ArtCat = {3}, ArtExpDate = '{4}' where ArtCode = {5}";
                    Req = string.Format(Req, Nom, Prix, Stock, Categorie, ExpDate, Key);
                    Con.EnvoyerDonnees(Req);
                    ListerArticles();
                    MessageBox.Show("Article Modifié !");
                    NomTb.Text = "";
                    PrixTb.Text = "";
                    StockTb.Text = "";
                    CatCb.SelectedIndex = -1;

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListerArticles();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void NomTb_TextChanged(object sender, EventArgs e)
        {

        }
        //Permet d'intégrer les informations dans les zones lors du clic
        int Key = 0;
        private void ArticlesListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NomTb.Text = ArticlesListe.SelectedRows[0].Cells[1].Value.ToString();
            PrixTb.Text = ArticlesListe.SelectedRows[0].Cells[2].Value.ToString();
            CatCb.Text = ArticlesListe.SelectedRows[0].Cells[3].Value.ToString();
            StockTb.Text = ArticlesListe.SelectedRows[0].Cells[4].Value.ToString();            
            if (NomTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(ArticlesListe.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void SupprimerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Key == 0)
                {
                    MessageBox.Show("Selectionnez un article !");
                }
                else
                {
                    if (NomTb != null && PrixTb != null && CatCb != null && StockTb != null)
                    {
                        String Nom = NomTb.Text;
                        int Prix = Convert.ToInt32(PrixTb.Text);

                        int Categorie = Convert.ToInt32(CatCb.SelectedValue.ToString());
                        int Stock = Convert.ToInt32(StockTb.Text);

                        string ExpDate = ExpTb.Value.Date.ToString();
                        string Req = "delete from Article where ArtCode = {0}";
                        Req = string.Format(Req, Key);
                        Con.EnvoyerDonnees(Req);
                        ListerArticles();
                        MessageBox.Show("Article supprimer !");
                        NomTb.Text = "";
                        PrixTb.Text = "";
                        StockTb.Text = "";
                        CatCb.SelectedIndex = -1;
                    }

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void FiltrerCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtrage();
        }

        

        private void label8_Click_1(object sender, EventArgs e)
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
            //Accès à vendeur autorisé 
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
