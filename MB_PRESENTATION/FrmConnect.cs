using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MB_METIER;
using MB_DONNES;

namespace MB_PRESENTATION
{
    public partial class FrmConnect : Form
    {
        public void loadListAllRepo()
        {
            List<string> allListRepo = RessourceDAO.SelectListRepo();
            
            listRepo.Items.Clear();

            foreach (var item in allListRepo)
            {
                listRepo.Items.Add(item);
            }
        }

        public FrmConnect()
        {
            InitializeComponent();

            loadListAllRepo();
        }

        private void btnCreateRepo_Click(object sender, EventArgs e)
        {
            string label = txtLabel.Text;
            string namespaceGit = txtNamespace.Text;

            int result = RessourceDAO.InsertRepo(label, namespaceGit);
            if (result == 1)
            {
                MessageBox.Show("Insertion de la Repo faite avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("L'insertion de la Repo n'a pas pu être executé", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            loadListAllRepo();
        }

        private void listRepo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selInd = listRepo.SelectedIndex;
            string item = listRepo.SelectedItems[selInd].ToString();

            this.Hide();
            FrmDisplay displayForm = new FrmDisplay(item);
            displayForm.ShowDialog();
            this.Close();
        }
    }
}
