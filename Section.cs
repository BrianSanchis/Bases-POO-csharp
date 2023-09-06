using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bases_POO
{
    public class Section
    {
        private string libelle;
        private List<Matiere> matieres = new List<Matiere>(); 

        public Section(string libelle)
        {
            this.libelle = libelle;
        }
        public string getLibelle()
        {
            return libelle;
        }
        public void setLibelle(string libelle)
        {
            this.libelle=libelle;
        }
        public void AddMatiere(Matiere matiere)
        {
            if(matiere != null)
            {
                matieres.Add(matiere);
            }
        }
    }
}
