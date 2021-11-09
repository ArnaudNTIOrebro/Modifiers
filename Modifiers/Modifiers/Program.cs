using System;

namespace Modifiers
{
    class Car
    {
        public string model = "Mustang"; // byt "public" mot "private" och kolla detsom händer i klassen under.
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car myObj = new Car();
            Console.WriteLine(myObj.model);


            string studentName = String.Empty;
            string studentTelephone = String.Empty;
            string student_Address = String.Empty;

            Student student1 = new Student("Trinity", "123454", 2021, true);
            studentName = student1.GetNamn();

            student1.PrintInfo();

            Student student2 = new Student("Neo", "019334455", 2021, false);
            studentTelephone = student2.GetTelefon();
            student2.PrintInfo();

            Console.ReadLine();
        }
    }
}
