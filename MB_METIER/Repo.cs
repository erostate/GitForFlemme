using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB_METIER
{
    public class Repo
    {
        #region Attributs
        private int ressId;
        private string label;
        private string typeRess;
        private int nbPlace;
        private string state;
        private string serialNumber;
        #endregion

        #region Accesseurs
        // Getters
        public int GetRessId()
        {
            return this.ressId;
        }
        public string GetLabel()
        {
            return this.label;
        }
        public string GetTypeRess()
        {
            return this.typeRess;
        }
        public int GetNbPlace()
        {
            return this.nbPlace;
        }
        public string GetState()
        {
            return this.state;
        }
        public string GetSerialNumber()
        {
            return this.serialNumber;
        }

        // Setters
        public void SetRessId(int newValue)
        {
            this.ressId = newValue;
        }
        public void SetLabel(string newValue)
        {
            this.label = newValue;
        }
        public void SetTypeRess(string newValue)
        {
            this.typeRess = newValue;
        }
        public void SetNbPlace(int newValue)
        {
            this.nbPlace = newValue;
        }
        public void SetState(string newValue)
        {
            this.state = newValue;
        }
        public void SetSerialNumber(string newValue)
        {
            this.serialNumber = newValue;
        }
        #endregion

        #region Méthodes
        /// <summary>
        /// Constructeur
        /// </summary>
        public Repo(string paramLabel, int paramNbPlace, string paramTypeRess)
        {
            Random rnd = new Random();
            this.ressId = rnd.Next();
            this.label = paramLabel;
            this.nbPlace = paramNbPlace;
            this.typeRess = paramTypeRess;
            this.state = "";
            this.serialNumber = "";
        }
        public Repo(string paramLabel, string paramState, string paramSerNum, string paramTypeRess)
        {
            Random rnd = new Random();
            this.ressId = rnd.Next();
            this.label = paramLabel;
            this.nbPlace = 0;
            this.state = paramState;
            this.serialNumber = paramSerNum;
            this.typeRess = paramTypeRess;
            this.nbPlace = 0;
        }
        #endregion
    }
}
