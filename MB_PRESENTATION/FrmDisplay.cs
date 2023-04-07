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
using MB_DONNES;

namespace MB_PRESENTATION
{
    public partial class FrmDisplay : Form
    {
        private string itemRepo;

        public FrmDisplay(string paramItemRepo)
        {
            InitializeComponent();
            this.itemRepo = paramItemRepo;
        }

        public string[,] IMyItem()
        {
            return RessourceDAO.SelectRepoConnect(itemRepo);
        }

        private void FrmDisplay_Load(object sender, EventArgs e)
        {
            string[,] myItem = IMyItem();
            if (myItem.Length > 0)
            {
                labelRepo.Text = myItem[0,2];
                string[,] listPc = RessourceDAO.SelectPcByRepo(myItem[0, 0]);

                if (listPc[0, 0] == null)
                {
                    Console.WriteLine(listPc[0, 0]);
                    // BTN Init
                    btnInitFolder.Enabled = false;

                    // Commande Envoyer
                    txtComCommit.Enabled = false;
                    btnAdd.Enabled = false;
                    btnCommit.Enabled = false;
                    btnPush.Enabled = false;
                    btnSendOneCom.Enabled = false;

                    // Commande PC
                    listPcExist.Enabled = false;
                    txtAddPcName.Focus();
                } else
                {
                    if (myItem[0, 3] == "false")
                    {
                        // BTN Init
                        btnInitFolder.Enabled = true;

                        // Commande Envoyer
                        txtComCommit.Enabled = false;
                        btnAdd.Enabled = false;
                        btnCommit.Enabled = false;
                        btnPush.Enabled = false;
                        btnSendOneCom.Enabled = false;
                    }
                    else
                    {
                        // BTN Init
                        btnInitFolder.Enabled = false;

                        // Commande Envoyer
                        txtComCommit.Enabled = true;
                        btnAdd.Enabled = true;
                        btnCommit.Enabled = true;
                        btnPush.Enabled = true;
                        btnSendOneCom.Enabled = true;

                        // Insertion des infos
                        txtAddPcFolder.Text = myItem[0, 4];
                        txtAddPcFolder.Enabled = false;
                    }
                }
            } else
            {
                Console.WriteLine("YEET");
            }
        }

        private void btnInitFolder_Click(object sender, EventArgs e)
        {
            string folder = txtAddPcFolder.Text;

            if (folder.Length > 0 )
            {
                // Nouveau processus CMD
                Process process = new Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = "/C cd " + folder + " && git init";
                process.StartInfo.CreateNoWindow = false; // Affiche la fenêtre CMD
                process.Start();

                // Attend la fin de l'exécution de CMD et ferme la fenêtre
                process.WaitForExit();
                process.Close();

                // Update de la BDD
                RessourceDAO.UpdateFolderRepo(txtAddPcFolder.Text, itemRepo);

                // Redirection sur une nouvelle page
                this.Hide();
                FrmDisplay displayForm = new FrmDisplay(itemRepo);
                displayForm.ShowDialog();
                this.Close();
            }
        }

        private void btnAddPc_Click(object sender, EventArgs e)
        {
            string[,] myItem = IMyItem();
            int resultAddPc = RessourceDAO.InsertPc(txtAddPcName.Text, txtAddPcFolder.Text, myItem[0, 0]);

            if (resultAddPc == 1)
                MessageBox.Show("Insertion du PC fait avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("L'insertion du PC n'a pas pu être executé", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            // Redirection sur une nouvelle page
            this.Hide();
            FrmDisplay displayForm = new FrmDisplay(itemRepo);
            displayForm.ShowDialog();
            this.Close();
        }
    }
}
