using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MB_METIER;
using MySql.Data.MySqlClient;

namespace MB_DONNES
{
    public class RessourceDAO
    {
        /// <summary>
        /// Séléction de la liste des repos
        /// </summary>
        /// <returns>Liste des repos</returns>
        public static List<string> SelectListRepo()
        {
            List<string> listAllRepo = new List<string>();
            try
            {
                MySqlConnection connexion = Connexion.SeConnecter();
                connexion.Open();

                MySqlCommand cmdSelect = new MySqlCommand();
                cmdSelect.CommandText = "SELECT namespace FROM repo";
                cmdSelect.Connection = connexion;

                MySqlDataReader dr = cmdSelect.ExecuteReader();
                while (dr.Read())
                {
                    listAllRepo.Add(dr.GetValue(0).ToString());
                }
                dr.Close();

                connexion.Close();

                return listAllRepo;
            }
            catch (Exception e)
            {
                Console.WriteLine("Erreur lors de l'insertion de la ressource" + e.Message);

                return listAllRepo;
            }
        }

        /// <summary>
        /// Insertion d'une repo
        /// </summary>
        /// <param name="R">Namespace du repo</param>
        /// <returns>Réussi: 1 | Pas réussi: 0</returns>
        public static int InsertRessource(Repo R)
        {
            try
            {
                MySqlConnection connexion = Connexion.SeConnecter();
                connexion.Open();
                MySqlCommand cmdInsert = new MySqlCommand();
                cmdInsert.Connection = connexion;
                cmdInsert.CommandText = "INSERT INTO Ressource(label, namespace)"
                + "VALUES (@label, @namespace)";
                cmdInsert.Parameters.AddWithValue("@label", R.GetLabel());
                cmdInsert.Parameters.AddWithValue("@namespace", Convert.ToInt32(R.GetNbPlace()));
                int res = cmdInsert.ExecuteNonQuery();
                connexion.Close();
                return res;
            }
            catch (Exception e)
            {
                Console.WriteLine("Erreur lors de l'insertion de la ressource" + e.Message);
                return 0;
            }
        }

        public static string SelectTypeInsertRess(string typeLabel)
        {
            try
            {
                // Marche pas (Erreur lors de l'insertion de la ressourceData too long for column 'type_ress' at row 1)
                MySqlConnection connexion = Connexion.SeConnecter();
                connexion.Open();

                MySqlCommand cmdSelect = new MySqlCommand();
                cmdSelect.CommandText = "SELECT type_code FROM `type_ress`"
                    + "WHERE label = '@label'";
                cmdSelect.Parameters.AddWithValue("@label", typeLabel);
                cmdSelect.Connection = connexion;

                MySqlDataReader dr = cmdSelect.ExecuteReader();
                string typeCode = dr.GetValue(0).ToString();
                dr.Close();

                connexion.Close();

                return typeCode;
            }
            catch (Exception e)
            {
                Console.WriteLine("Erreur lors de l'insertion de la ressource" + e.Message);

                return "error";
            }
        }
    }
}
