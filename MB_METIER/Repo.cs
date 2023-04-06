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
        private int repoId;
        private string label;
        private string nmsp;
        #endregion

        #region Accesseurs
        // Getters
        public int GetRepoId()
        {
            return this.repoId;
        }
        public string GetLabel()
        {
            return this.label;
        }
        public string GetNmsp()
        {
            return this.nmsp;
        }

        // Setters
        public void SetRepoId(int newValue)
        {
            this.repoId = newValue;
        }
        public void SetLabel(string newValue)
        {
            this.label = newValue;
        }
        public void SetNmsp(string newValue)
        {
            this.nmsp = newValue;
        }
        #endregion

        #region Méthodes
        /// <summary>
        /// Constructeur
        /// </summary>
        public Repo(int ParamRepoId, string paramLabel, string paramNmsp)
        {
            Random rnd = new Random();
            this.repoId = rnd.Next();
            this.label = paramLabel;
            this.nmsp = paramNmsp;
        }
        #endregion
    }
}
