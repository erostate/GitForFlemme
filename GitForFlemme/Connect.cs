using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DATA;
using JOB;

namespace GitForFlemme
{
    public partial class Connect : Form
    {
        public Connect()
        {
            InitializeComponent();

            try
            {
                MySqlConnection connexion = Data.SeConnecter();
                connexion.Open();

                MySqlCommand cmdSelect = new MySqlCommand();
                cmdSelect.CommandText = "SELECT namespace_git FROM repo";
                cmdSelect.Connection = connexion;

                MySqlDataReader dr = cmdSelect.ExecuteReader();
                while (dr.Read())
                {
                    listRepo.Items.Add(dr.GetValue(0));
                }
                dr.Close();

                connexion.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Erreur lors de l'insertion de la ressource" + e.Message);
            }
        }

        /// <summary>
        /// Récupérer le Repo ID via le namespace
        /// </summary>
        /// <param name="namespace_git">Namespace</param>
        /// <returns>Repo ID</returns>
        public int GetRepoId(string namespace_git)
        {
            try
            {
                MySqlConnection connexion = Data.SeConnecter();
                connexion.Open();

                MySqlCommand cmdSelect = new MySqlCommand();
                cmdSelect.CommandText = "SELECT repo_id FROM repo WHERE namespace_git = @nsp";
                cmdSelect.Connection = connexion;

                cmdSelect.Parameters.AddWithValue("@nsp", namespace_git);

                int repo_id = 0;

                MySqlDataReader dr = cmdSelect.ExecuteReader();
                while (dr.Read())
                {
                    repo_id = int.Parse(dr.GetValue(0).ToString());
                }
                dr.Close();

                connexion.Close();

                return repo_id;
            }
            catch (Exception e)
            {
                Console.WriteLine("Erreur lors de l'insertion de la ressource" + e.Message);

                return 0;
            }
        }

        /// <summary>
        /// Récupérer le Repo ID via le namespace
        /// </summary>
        /// <param name="namespace_git">Namespace</param>
        /// <returns>Repo ID</returns>
        public string GetRepoName(string namespace_git)
        {
            try
            {
                MySqlConnection connexion = Data.SeConnecter();
                connexion.Open();

                MySqlCommand cmdSelect = new MySqlCommand();
                cmdSelect.CommandText = "SELECT name FROM repo WHERE namespace_git = @nsp";
                cmdSelect.Connection = connexion;

                cmdSelect.Parameters.AddWithValue("@nsp", namespace_git);

                string repo_name = "";

                MySqlDataReader dr = cmdSelect.ExecuteReader();
                while (dr.Read())
                {
                    repo_name = dr.GetValue(0).ToString();
                }
                dr.Close();

                connexion.Close();

                return repo_name;
            }
            catch (Exception e)
            {
                Console.WriteLine("Erreur lors de l'insertion de la ressource" + e.Message);

                return "";
            }
        }

        private void btnYeet_Click(object sender, EventArgs e)
        {
            //string folder = inpFolder.Text;

            //// Crée un nouveau processus CMD
            //Process process = new Process();
            //process.StartInfo.FileName = "cmd.exe";
            //process.StartInfo.Arguments = "/C cd " + folder + " && git init"; // Spécifie la commande à exécuter
            //process.StartInfo.CreateNoWindow = false; // Affiche la fenêtre CMD
            //process.Start(); // Lance le processus

            //// Attend la fin de l'exécution de CMD et ferme la fenêtre
            //process.WaitForExit();
            //process.Close();
        }

        private void listRepo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int repo_id = GetRepoId(listRepo.SelectedValue.ToString());
            string name = GetRepoName(listRepo.SelectedValue.ToString());
            //Job.Job

            this.Hide();
            Display displayForm = new Display();
            displayForm.ShowDialog();
            this.Close();
        }
    }
}
