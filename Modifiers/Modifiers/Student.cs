using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modifiers
{
    class Student : Person
    {
        int inskrivningsår;
        bool betaldKåravgift;

        public Student(string n, string t, int år, bool betalat) : base(n, t)
        {
            inskrivningsår = år;
            betaldKåravgift = betalat;
        }
        public void PrintInfo()
        {
            Console.WriteLine("Namn: " + base.GetNamn());
            Console.WriteLine("TelNr: " + base.GetTelefon());
            Console.WriteLine("Address: " + base.address);
            if (betaldKåravgift)
            {
                Console.WriteLine("Kåravgiften är betald!\n");
            }
        }
    }
}
