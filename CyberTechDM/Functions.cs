using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CyberTechDM
{
    //Classe C# nommée Functions qui fournir des méthodes pour interagir avec la BDD locale CyberTechDM
    class Functions
    {
        private SqlConnection Con;
        private SqlCommand Cmd;
        private DataTable dt;
        private SqlDataAdapter sda;
        private string ConString;

        public Functions()
        {
            //Chaine de connexion à la BDD
            ConString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Utilisateur 1\Documents\Projects Visual Studio 2022\CyberTechDM.mdf"";Integrated Security=True;Connect Timeout=30";
            // Initialisation de l'objet SqlConnection et SqlCommand
            Con = new SqlConnection(ConString);
            Cmd = new SqlCommand();
            Cmd.Connection = Con;

        }

        //La fonction RecupererDonnees est une fonction utilisée pour exécuter une requête SQL sur la
        //base de données à l'aide d'un objet SqlDataAdapter et récupérer
        //les résultats dans un objet DataTable.
        public DataTable RecupererDonnees(string Req)
        {
            // Création d'un objet DataTable 
            dt = new DataTable();
            // Création d'un objet SqlDataAdapter 
            sda = new SqlDataAdapter(Req, ConString);
            // Remplissez le DataTable avec les données résultantes de la requête
            sda.Fill(dt);
            // Renvoyez le DataTable rempli
            return dt;
        }

        // La fonction EnvoyerDonnees est utilisée pour exécuter une requête SQL qui
        // modifie les données dans la base de données.
        public int EnvoyerDonnees(string Req)
        {
            // Initialisation du compteur
            int cnt = 0;
            // Vérification si la connexion est ouverte; si non, ouvrir la connexion
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            // Attribution de la requête SQL à la propriété CommandText de
            // l'objet SqlCommand
            Cmd.CommandText = Req;
            // Exécution de la commande SQL et récupération du nombre de
            // lignes affectées
            cnt = Cmd.ExecuteNonQuery();
            // Renvoi du nombre de lignes affectées
            return cnt;
        }




    }

    
}
