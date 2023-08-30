using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bases_POO
{
    public class Personne
    {
        private int id;
        private string name;
        private string surname;
        private DateTime birthDate;

        //Constructeur
        public Personne(int id,string name)
        {
            this.id = id;
            this.name = name;

        }
        public Personne(int id, string name, string surname) : this(id, name)
        {
            this.surname = surname;
        }
        public Personne(int id, string name, string surname, DateTime birthDate) : this(id, name, surname)
        {
            this.birthDate = birthDate;
        }
        //Getter et setter sauce POO
        public int getId()
        {
            return id;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name.ToUpper();
        }
        //Getter et setter sauce Microsoft
        public string Surname
        {
            get { return surname; }
            set { this.surname = value; }
        }
        public DateTime BirthDate
        {
            get { return birthDate; }
            set 
            { 
                if (value.Year < DateTime.Now.Year)
                {
                    birthDate = value;
                }
            }
        }
        public int getAge()
        {
            int age = 0;
            if (birthDate != null)
            {
                age = DateTime.Now.Year - birthDate.Year;
            }
            return age;
        }
        public virtual void show()
        {
            Console.WriteLine("Mon nom est : " + name + "\t" + "Et mon prénom est : " + this.surname);
        }
    }
}
