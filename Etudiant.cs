using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bases_POO
{
    public class Etudiant : Personne
    {
        private string studentId;
        private Section section;

        public Etudiant(int id, string name, string surname, DateTime birthDate, string numEtudiant) : base(id, name, surname, birthDate)
        {
            numEtudiant = studentId;
        }
        public Etudiant(int id, string name, string surname, DateTime birthDate, string numEtudiant, Section section) : base(id, name ,surname, birthDate)
        {
            this.section = section;
        }
        public void setSection(Section SIO2)
        {
            section = SIO2;
        }
        public virtual void show()
        {
            base.show();
            Console.WriteLine("Numéro d'étudiant : " + "\t" + studentId);
            Console.WriteLine("Section de l'étudiant : " + "\t" +  section);
        }
    }
}
