using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UniformSystem
{
    internal class Pupil : IComparable<Pupil>
    {

        private string fName;
        private string sName;
        private string reg;

        public Pupil(string forename, string surname, string regiclass) { 
            fName = forename;
            sName = surname;
            reg = regiclass;
        }

        public string getForename() { return fName; }
        public string getSurname() { return sName; }
        public string getRegiclass() { return reg; }

        public int CompareTo(Pupil other)
        {
            return String.Compare(this.sName, other.sName, comparisonType: StringComparison.OrdinalIgnoreCase);
        }
    }
}
