using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    class Controller
    {
        List<Student> listaStudentow = new List<Student>();

        public Controller()
        {
            Console.WriteLine("Witaj w programie 'Student Manager' - aplikacja do zarządzania bazą studentów");

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("D-dodaj studenta, W-wyświetl listę studentów, O - dodaj ocenę, U-usuń studenta, P-podlicz, Z-zakończ");
                String dec = Console.ReadLine().ToUpper();

                switch (dec)
                {
                    case "D":
                        Console.WriteLine("Podaj imię studenta");
                        string imie = Console.ReadLine();
                        Console.WriteLine("Podaj nazwisko studenta");
                        string nazwisko = Console.ReadLine();
                        Console.WriteLine("Podaj numer indeksu studenta");
                        int indeks = Convert.ToInt32(Console.ReadLine());
                        Student s = new Student(imie, nazwisko, indeks);
                        listaStudentow.Add(s);
                        break;

                    case "W":
                        Console.WriteLine("Lista studentów: ");
                        foreach (Student tmp in listaStudentow)
                        {
                            Console.Write("Imię: " + tmp.Imie + " Nazwisko: " + tmp.Nazwisko + " Nr indeksu: " + tmp.NrIndeksu +" ");
                            Console.Write("Lista ocen: ");

                            foreach (int ocenki in tmp.ListaOcen)
                            {
                                Console.Write(ocenki + ", ");
                            }
                            Console.WriteLine(  );
                            
                        }
                        break;

                    case "O":
                        Console.WriteLine("Podaj numer indeksu studenta do wprowadzenia oceny");
                        int indexo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Podaj ocenę do wprowadzenia");
                        int ocena = Convert.ToInt32(Console.ReadLine());

                        foreach (Student st in listaStudentow)
                        {

                            if (st.NrIndeksu == indexo)
                            {
                                st.ListaOcen.Add(ocena);
                                Console.WriteLine("Dodano ocenę");
                                break;
                            }
                        }
                        break;
                        
                    case "U":
                        Console.WriteLine("Podaj numer indeksu studenta do usunięcia");
                        int index = Convert.ToInt32(Console.ReadLine());
                        foreach (Student st in listaStudentow)
                        {
                            
                            if (st.NrIndeksu == index) { 
                                listaStudentow.RemoveAt(listaStudentow.IndexOf(st));
                                Console.WriteLine("Usunięto studenta!");
                                Student.liczbaStudentow--;
                                break;
                            }
                        }
                        break;

                    case "P":
                        Console.WriteLine("Liczba studentów = "+ Student.liczbaStudentow);
                        break;

                    case "Z":
                        Console.WriteLine("Do zobaczenia!");
                        flag = false;
                        break;




                }

            }

        }
        


    }
}
