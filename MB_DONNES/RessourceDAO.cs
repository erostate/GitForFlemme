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
                Console.WriteLine("Erreur lors de la recherche du Repo (SelectListRepo) : " + e.Message);

                return listAllRepo;
            }
        }

        /// <summary>
        /// Insertion d'une repo
        /// </summary>
        /// <param name="R">Namespace du repo</param>
        /// <returns>Réussi: 1 | Pas réussi: 0</returns>
        public static int InsertRepo(string label, string nmsp)
        {
            try
            {
                MySqlConnection connexion = Connexion.SeConnecter();
                connexion.Open();
                MySqlCommand cmdInsert = new MySqlCommand();
                cmdInsert.Connection = connexion;
                cmdInsert.CommandText = "INSERT INTO repo(label, namespace)"
                + "VALUES (@label, @namespace)";
                cmdInsert.Parameters.AddWithValue("@label", label);
                cmdInsert.Parameters.AddWithValue("@namespace", nmsp);
                int res = cmdInsert.ExecuteNonQuery();
                connexion.Close();
                return res;
            }
            catch (Exception e)
            {
                Console.WriteLine("Erreur lors de l'insertion de la Repo (InsertRepo) : " + e.Message);
                return 0;
            }
        }

        public static string[,] SelectRepoConnect(string repoNmsp)
        {
            try
            {
                MySqlConnection connexion = Connexion.SeConnecter();
                connexion.Open();

                MySqlCommand cmdSelect = new MySqlCommand();
                cmdSelect.CommandText = "SELECT repo_id, label, init FROM `repo`"
                    + "WHERE namespace = @nmsp";
                cmdSelect.Parameters.AddWithValue("@nmsp", repoNmsp);
                cmdSelect.Connection = connexion;

                string[,] tablRepo = new string[2, 4];

                MySqlDataReader dr = cmdSelect.ExecuteReader();
                if (dr.Read())
                {
                    tablRepo[0, 0] = dr.GetValue(0).ToString();
                    tablRepo[0, 1] = dr.GetValue(1).ToString();
                    tablRepo[0, 2] = repoNmsp;
                    tablRepo[0, 3] = dr.GetValue(2).ToString();
                }
                dr.Close();

                connexion.Close();

                return tablRepo;
            }
            catch (Exception e)
            {
                Console.WriteLine("Erreur lors de la recherche du Repo (SelectRepoConnect) : " + e.Message);

                return new string[1,4];
            }
        }

        /// <summary>
        /// Retourner la liste des PC pour un Repo
        /// </summary>
        /// <param name="repoNmsp"></param>
        /// <returns></returns>
        public static string[,] SelectPcByRepo(string repoId)
        {
            try
            {
                MySqlConnection connexion = Connexion.SeConnecter();
                connexion.Open();

                MySqlCommand cmdSelect = new MySqlCommand();
                cmdSelect.CommandText = "SELECT label, description, folder FROM `desktop`"
                    + "WHERE repo = @repoId";
                cmdSelect.Parameters.AddWithValue("@repoId", repoId);
                cmdSelect.Connection = connexion;

                string[,] tablPC = new string[10, 4];

                MySqlDataReader dr = cmdSelect.ExecuteReader();
                int i = 0;
                while (dr.Read())
                {
                    tablPC[i, 0] = dr.GetValue(0).ToString();
                    tablPC[i, 1] = dr.GetValue(1).ToString();
                    tablPC[i, 2] = dr.GetValue(2).ToString();
                    tablPC[i, 3] = repoId;
                    i++;
                }
                dr.Close();

                connexion.Close();

                return tablPC;
            }
            catch (Exception e)
            {
                Console.WriteLine("Erreur lors de la recherche du Repo (SelectPcByRepo) : " + e.Message);

                return new string[1, 3];
            }
        }

        /// <summary>
        /// Insertion d'un PC
        /// </summary>
        /// <param name="R">ID du repo</param>
        /// <returns>Réussi: 1 | Pas réussi: 0</returns>
        public static int InsertPc(string label, string folder, string repo)
        {
            try
            {
                MySqlConnection connexion = Connexion.SeConnecter();
                connexion.Open();
                MySqlCommand cmdInsert = new MySqlCommand();
                cmdInsert.Connection = connexion;
                cmdInsert.CommandText = "INSERT INTO desktop(label, folder, repo)"
                + "VALUES (@label, @folder, @repo)";
                cmdInsert.Parameters.AddWithValue("@label", label);
                cmdInsert.Parameters.AddWithValue("@folder", folder);
                cmdInsert.Parameters.AddWithValue("@repo", repo);
                int res = cmdInsert.ExecuteNonQuery();
                connexion.Close();
                return res;
            }
            catch (Exception e)
            {
                Console.WriteLine("Erreur lors de l'insertion du PC (InsertPc) : " + e.Message);
                return 0;
            }
        }

        /// <summary>
        /// Modification du Folder d'une repo
        /// </summary>
        /// <param name="R">Namespace du repo</param>
        /// <returns>Réussi: 1 | Pas réussi: 0</returns>
        public static int UpdateFolderRepo(string newFolder, string nmsp)
        {
            try
            {
                // A faire
                MySqlConnection connexion = Connexion.SeConnecter();
                connexion.Open();
                MySqlCommand cmdInsert = new MySqlCommand();
                cmdInsert.Connection = connexion;
                cmdInsert.CommandText = "UPDATE repo SET folder = @folder WHERE repo_id = @repoId";
                cmdInsert.Parameters.AddWithValue("@folder", newFolder);
                cmdInsert.Parameters.AddWithValue("@namespace", nmsp);
                int res = cmdInsert.ExecuteNonQuery();
                connexion.Close();
                return res;
            }
            catch (Exception e)
            {
                Console.WriteLine("Erreur lors de l'update de la Repo (UpdateFolderRepo) : " + e.Message);
                return 0;
            }
        }
    }
}
