using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;
using static System.Net.Mime.MediaTypeNames;

namespace CyberTechDM
{
    public partial class Factures : Form
    {
        Functions Con;
        public Factures()
        {
            InitializeComponent();
            // Mettre à jour l'étiquette avec le nom de l'utilisateur connecté
            VendeurLbl.Text = Connexion.UserName;
            Con = new Functions();
            ListerArticles();
        }

        // Fonction pour recalculer le montant total de la facture
        private void RecalculerMontantTotalFacture()
        {
            int nouveauTotal = 0;
            foreach (DataGridViewRow row in FactureListe.Rows)
            {
                nouveauTotal += Convert.ToInt32(row.Cells[4].Value);
            }
            GrdTotal = nouveauTotal;
            PrixTotalLbl.Text = GrdTotal.ToString() + "$";
        }

        private void ListerArticles()
        {
            //Récupère ArtCode,ArtNom,ArtPrix,ArtStock dans Article et CatNom dans Categorie + jointure de Categorie sur ArtCat de Article pour avoir nom et non code + affiche dans ArticleListe
            string Req = "Select ArtCode as Code, ArtNom as Article, ArtPrix as Prix, CatNom as Categorie, ArtStock as Stock from Article join Categorie on Article.ArtCat = Categorie.CatCode";
            ArticlesListe.DataSource = Con.RecupererDonnees(Req);
        }

        private int GetStockFromDatabase(int articleCode)
        {
            int stock = 0;
            try
            {
                // Exécutez la requête pour récupérer le stock de l'article à partir de la base de données
                string query = $"SELECT ArtStock FROM Article WHERE ArtCode = {articleCode}";
                DataTable dt = Con.RecupererDonnees(query);

                // Vérifiez si des données ont été retournées
                if (dt.Rows.Count > 0)
                {
                    // Récupérez le stock depuis la première ligne du DataTable
                    stock = Convert.ToInt32(dt.Rows[0]["ArtStock"]);
                }
            }
            catch (Exception ex)
            {
                // Gérez les éventuelles exceptions
                MessageBox.Show($"Erreur lors de la récupération du stock depuis la base de données : {ex.Message}");
            }
            return stock;
        }

        private void VendeurLbl_Click(object sender, EventArgs e)
        {

        }

        int Key = 0;
        private void ArticlesListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NomTb.Text = ArticlesListe.SelectedRows[0].Cells[1].Value.ToString();
            PrixTb.Text = ArticlesListe.SelectedRows[0].Cells[2].Value.ToString();
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

        private void AjouterBtn_Click(object sender, EventArgs e)
        {

        }

        private void ReinitialiserBtn_Click(object sender, EventArgs e)
        {
            NomTb.Text = "";
            PrixTb.Text = "";
            StockTb.Text = "";
            QntTb.Text = "";
        }
        private void ModifierStock()
        {
            int Stock = Convert.ToInt32(StockTb.Text);
            int NewStock = Stock - Convert.ToInt32(QntTb.Text);

            string Req = "Update Article set ArtStock = {0} where ArtCode = {1}";
            Req = string.Format(Req, NewStock, Key);
            Con.EnvoyerDonnees(Req);
            ListerArticles();
        }
        int n = 0;
        int GrdTotal = 0;
        private void ModifierBtn_Click(object sender, EventArgs e)
        {
            if(NomTb.Text == "" || PrixTb.Text == "" || StockTb.Text == "" || QntTb.Text == "")
            {
                MessageBox.Show("Information Manquantes !");
            }
            {
                if(Convert.ToInt32(QntTb.Text) > Convert.ToInt32(StockTb.Text)) {
                    MessageBox.Show("Stock non disponible ! ");
                }
                else
                {
                    int total = Convert.ToInt32(QntTb.Text) * Convert.ToInt32(PrixTb.Text);
                    DataGridViewRow Ligne= new DataGridViewRow();
                    Ligne.CreateCells(FactureListe);
                    Ligne.Cells[0].Value = n+1;
                    Ligne.Cells[1].Value = NomTb.Text;
                    Ligne.Cells[2].Value = QntTb.Text;
                    Ligne.Cells[3].Value = PrixTb.Text;
                    Ligne.Cells[4].Value = total;
                    GrdTotal = GrdTotal + total;
                    FactureListe.Rows.Add(Ligne);
                    PrixTotalLbl.Text = GrdTotal + "$";
                    ModifierStock();
                    NomTb.Text = "";
                    PrixTb.Text = "";
                    StockTb.Text = "";
                    QntTb.Text = "";
                    n++;



                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }
        //Permet d'intégrer les informations dans les zones lors du clic
        private void FactureListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NomTb.Text = FactureListe.SelectedRows[0].Cells[1].Value.ToString();
            QntTb.Text = FactureListe.SelectedRows[0].Cells[2].Value.ToString();
            PrixTb.Text = FactureListe.SelectedRows[0].Cells[3].Value.ToString();
            StockTb.Text = FactureListe.SelectedRows[0].Cells[4].Value.ToString();
            if (NomTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(FactureListe.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        private void InsererFacture()
        {
            try
            {
                int Vendeur = Connexion.UserId;
                string Req = "insert into Article values('{0}',{1},{2})";
                Req = string.Format(Req, DateTime.Today.ToString(), Vendeur, GrdTotal);
                Con.EnvoyerDonnees(Req);
                ListerArticles();
                MessageBox.Show("Facturee Ajoutée !");
            }
            catch (Exception Ex)
            {

            }
            
        }
        private void ImprimerBtn_Click(object sender, EventArgs e)
        {
            InsererFacture();
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
        int ACode, APrix, AQty, ATotal;

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

        private void ModifierBtn2_Click(object sender, EventArgs e)
        {
            
        }

        private void SupprimerBtn_Click(object sender, EventArgs e)
        {
            if (FactureListe.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = FactureListe.SelectedRows[0];
                string articleNom = selectedRow.Cells[1].Value.ToString(); // Récupérer le nom de l'article à supprimer
                int quantiteASupprimer = Convert.ToInt32(selectedRow.Cells[2].Value); // Récupérer la quantité à supprimer
                int totalArticle = Convert.ToInt32(selectedRow.Cells[4].Value);
                
                

                // Mettre à jour le stock de l'article dans la base de données
                string requeteStock = $"UPDATE Article SET ArtStock = ArtStock + {quantiteASupprimer} WHERE ArtNom = '{articleNom}'";
                Con.EnvoyerDonnees(requeteStock);

                // Soustraire le montant total de l'article supprimé du total actuel
                GrdTotal -= totalArticle;
                PrixTotalLbl.Text = GrdTotal.ToString() + "$";

                // Supprimer la ligne de la facture
                FactureListe.Rows.Remove(selectedRow);

                // Rafraîchir les données de la liste des articles dans la rubrique facturation
                ListerArticles();


                // Effacer les informations des zones de texte
                NomTb.Text = "";
                QntTb.Text = "";
                PrixTb.Text = "";
                StockTb.Text = "";
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne à supprimer de la facture.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (NomTb.Text == "" || QntTb.Text == "" || PrixTb.Text == "" || StockTb.Text == "")
                {
                    MessageBox.Show("Completer les champs svp !");
                }
                else
                {
                    // Récupérer la ligne sélectionnée dans la grille de la facture
                    if (FactureListe.SelectedRows.Count > 0)
                    {
                        DataGridViewRow selectedRow = FactureListe.SelectedRows[0];

                        // Obtenez la quantité actuelle de cet article dans la facture
                        int ancienneQuantite = Convert.ToInt32(selectedRow.Cells[2].Value);
                        int nouvelleQuantite = Convert.ToInt32(QntTb.Text);

                        // Calculez la différence entre la nouvelle quantité et l'ancienne quantité
                        int differenceQuantite = nouvelleQuantite - ancienneQuantite;

                        // Mettez à jour la quantité dans la ligne de la facture avec la nouvelle quantité
                        selectedRow.Cells[2].Value = nouvelleQuantite;

                        // Mettez à jour le stock dans la base de données
                        int articleCode = Convert.ToInt32(selectedRow.Cells["Code"].Value);
                        int stockActuel = GetStockFromDatabase(articleCode);
                        int nouveauStock = stockActuel - differenceQuantite;
                        string requeteMiseAJourStock = $"UPDATE Article SET ArtStock = {nouveauStock} WHERE ArtCode = {articleCode}";
                        Con.EnvoyerDonnees(requeteMiseAJourStock);

                        // Rafraîchir les données de la liste des articles dans la rubrique facturation
                        ListerArticles();

                        // Recalculer le montant total de la facture
                        RecalculerMontantTotalFacture();
                    }
                    else
                    {
                        MessageBox.Show("Veuillez sélectionner une ligne dans la facture pour modifier la quantité.");
                    }

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        string ANom;
        int pos = 60;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Notre SuperMarChe", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(80));
            e.Graphics.DrawString("ID PRODUCT PRICE QUANTITY TOTAL", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Red, new Point(26, 40));
            foreach (DataGridViewRow row in FactureListe.Rows)
            {
                ACode = Convert.ToInt32(row.Cells["Column1"].Value);
                ANom = "" + row.Cells["Column2"].Value;
                APrix = Convert.ToInt32(row.Cells["Column3"].Value);
                AQty = Convert.ToInt32(row.Cells["Column4"].Value);
                ATotal = Convert.ToInt32(row.Cells["Column5"].Value);
                e.Graphics.DrawString("" + ACode, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(26, pos)); 
                e.Graphics.DrawString("" + ANom, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(45, pos)); 
                e.Graphics.DrawString("" + APrix, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(120, pos)); 
                e.Graphics.DrawString("" + AQty, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(170, pos));
                e.Graphics.DrawString("" + ATotal, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(235, pos)); 
                pos=pos+20;
            }
            e.Graphics.DrawString("Grand Total" + GrdTotal + "$", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Crimson, new Point(50, pos + 50));
            e.Graphics.DrawString("**************SMarche**************",new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Crimson, new Point(10, pos + 85));
            FactureListe.Rows.Clear();
            FactureListe.Refresh();
            pos = 100;
            GrdTotal = 0;
            n = 0;
            PrixTotalLbl.Text = "";
        }
    }
}
