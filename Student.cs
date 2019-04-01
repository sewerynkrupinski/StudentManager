using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    class Student
    {

        public static int liczbaStudentow = 0;

        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int NrIndeksu { get; set; }
        public List<int> ListaOcen { get; set; }

        public Student(string imie, string nazwisko, int nrIndeksu)
        {
            this.Imie = imie;
            this.Nazwisko = nazwisko;
            this.NrIndeksu = nrIndeksu;
            this.ListaOcen = new List<int>();

            liczbaStudentow++;
        }
    }
}
