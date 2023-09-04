using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bases_POO
{
    public class Matiere
    {
        private string libelle;
        private float nbHeure;

        public Matiere(string libelle, float nbHeure)
        {
            this.libelle = libelle;
            this.nbHeure = nbHeure;
        }
        public string Libelle
        {
            get { return libelle; }
            set { libelle = value; }
        }
        public float setNbHeure()
        {
            return nbHeure;
        }
        public void setNbHeure(float nbHeure)
        {
            this.nbHeure = nbHeure;
        }
    }
}
