using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bases_POO
{
    public class Section
    {
        private string name;

        public Section(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name=name;
        }
    }
}
