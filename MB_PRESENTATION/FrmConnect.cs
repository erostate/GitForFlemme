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
        public List<string> allListRepo = RessourceDAO.SelectListRepo();

        public string RecupCodeTypeRess(string label)
        {
            string tmp = "error";
            for (int i = 0; i < allListRepo.Count; i++)
            {
                if (allListRepo[i] == label)
                {
                    tmp = allListRepo[i];
                }
            }
            return tmp;
        }

        public FrmConnect()
        {
            InitializeComponent();

            foreach (var item in allListRepo)
            {
                listRepo.Items.Add(item);
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            string labelRess = txtLabel.Text;
            int nbPlace = (int)txtNbPlace.Value;
            string state = txtState.Text;
            string serialNumber = txtSerialNumber.Text;
            string typeRess = RecupCodeTypeRess(txtType.Text);

            int returnInsRess = 0;
            if (typeRess == "PC")
            {
                Repo ress = new Repo(labelRess, state, serialNumber, typeRess);
                returnInsRess = RessourceDAO.InsertRessource(ress);
            } else
            {
                Repo ress = new Repo(labelRess, nbPlace, typeRess);
                returnInsRess = RessourceDAO.InsertRessource(ress);
            }

            if (returnInsRess == 0)
                MessageBox.Show("Erreur: La ressource n'a pas pu être ajoutée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Ressource ajoutée avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtLabel.Clear();
            txtType.SelectedIndex = -1;
            txtNbPlace.Value = 1;
            txtState.SelectedIndex = -1;
            txtSerialNumber.Clear();
            txtLabel.Focus();
        }

        private void txtType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtType.Text == "Ordinateur")
            {
                txtNbPlace.Enabled = false;
                txtState.Enabled = true;
                txtSerialNumber.Enabled = true;
            } else
            {
                txtNbPlace.Enabled = true;
                txtState.Enabled = false;
                txtSerialNumber.Enabled = false;
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            txtLabel.Clear();
            txtType.SelectedIndex = -1;
            txtNbPlace.Value = 1;
            txtState.SelectedIndex = -1;
            txtSerialNumber.Clear();
            txtLabel.Focus();
        }

        private void btnRedirectUpdateRess_Click(object sender, EventArgs e)
        {
            //Maybe afficher une popup avec la liste des ressources et qui demande laquelle on veux choisir
        }
    }
}
