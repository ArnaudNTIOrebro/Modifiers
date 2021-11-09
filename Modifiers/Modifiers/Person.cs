using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modifiers
{
    class Person
    {
        private string namn;
        private string telefon;

        protected string address = "calle de Mimosa, Madrid";  // byt "protected" mot "private" och kolla det som händer i "student" filen 

        public Person(string namn, string telefon)
        {
            this.namn = namn;
            this.telefon = telefon;
        }

        public string GetNamn()
        {
            return namn;
        }
        public string GetTelefon() => telefon;
    }
}
