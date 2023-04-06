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
        /// Insertion d'une ressource dans la base de donnée
        /// </summary>
        /// <param name="R">Ressource</param>
        /// <returns>Réussi: 1 | Pas réussi: 0</returns>
        public static int InsertRessource(Repo R)
        {
            try
            {
                MySqlConnection connexion = Connexion.SeConnecter();
                connexion.Open();
                MySqlCommand cmdInsert = new MySqlCommand();
                cmdInsert.Connection = connexion;
                cmdInsert.CommandText = "INSERT INTO Ressource(label, nb_place, state, serial_number, type_ress)"
                + "VALUES (@libelle, @places, @state, @serialNum, @type)";
                cmdInsert.Parameters.AddWithValue("@libelle", R.GetLabel());
                cmdInsert.Parameters.AddWithValue("@places", Convert.ToInt32(R.GetNbPlace()));
                cmdInsert.Parameters.AddWithValue("@state", R.GetState());
                cmdInsert.Parameters.AddWithValue("@serialNum", R.GetSerialNumber());
                cmdInsert.Parameters.AddWithValue("@type", R.GetTypeRess());
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

        /// <summary>
        /// Séléction de la liste des types ressource pour l'afficher dans le menu de séléction
        /// </summary>
        /// <returns>Liste des types ressource</returns>
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
