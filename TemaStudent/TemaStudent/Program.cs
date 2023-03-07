using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Student> students = new List<Student>();   //adaugam numele in lista
            List<DateUniv> univs = new List<DateUniv>();
            int n, ID, choice, anStudiu;
            string name, prenume, adresa, sec,dateUniv, specializarea, Date;   
            int ctr = 0;
                                   
                do
                {
                    Console.WriteLine("Alegeti o optiune!: ");
                    Console.WriteLine("1. Adaugare Student");
                    Console.WriteLine("2. Afisare Lista");
                    choice = int.Parse(Console.ReadLine()); // convertim int la string
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Cati studenti doriti sa inregistrati?");
                            n = int.Parse(Console.ReadLine());
                            for (int i = 0; i < n; i++)
                            {
                                Console.WriteLine("Introduceti ID-ul:" + (i + 1));
                                ID = int.Parse(Console.ReadLine());

                                Console.WriteLine("Introduceti Numele studentului: " + (i + 1));
                                name = Console.ReadLine();

                                Console.WriteLine("Introduceti Prenumele studentului:" + (i + 1));
                                prenume = Console.ReadLine();

                                Console.WriteLine("Introduceti Adresa studentului:" + (i + 1));
                                adresa = Console.ReadLine();
                                Console.WriteLine("Datele universitare:");
                                dateUniv=null;
                            



                            Student studenti = new Student(name, ID, prenume, adresa, dateUniv);
                                students.Add(studenti);

                                Console.WriteLine("Introduceti specializarea:" + (i+1));
                                specializarea = Console.ReadLine();
                                Console.WriteLine("Introduceti anul de studiu:" + (i+1));
                                anStudiu = int.Parse( Console.ReadLine());
                                Console.WriteLine("Introduceti universitatea:" + (i + 1));
                                Date = Console.ReadLine();

                                DateUniv DateUniversitate = new DateUniv(specializarea, anStudiu, Date);
                                univs.Add(DateUniversitate);
                                                                
                                studenti.Date_Univ = ("Specializarea: \t" + specializarea + "\nanul:\t" + anStudiu +"\nUniversitatea:\t" + Date);
                                                          
                                                                
                            }
                            break;

                        case 2:
                            Console.WriteLine("Afisare studenti");
                            Console.WriteLine("-----------------------------------");

                            int contor = students.Count; // Contorizam studentii
                            if (contor != 0)    //daca lista nu e vida, afisam lista
                            {
                            foreach (Student student in students)
                            {
                                Console.WriteLine("ID-ul:\t " + student.getID());
                                Console.WriteLine("Numele Studentului: " + student.getName());
                                Console.WriteLine("Prenume Studentului: " + student.getprenume());
                                Console.WriteLine("Adresa Studentului: " + student.getadresa());
                                Console.WriteLine("ID-ul\t" + student.getID() + "\teste inscris la:\n -----------------------------------\n" 
                                    + student.getdateUniv());
                                    Console.WriteLine("\n");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Lista este vida!");
                            }
                            break;

                        default:
                            Console.WriteLine("Alegeti din nou");
                            break;
                    }
                    Console.WriteLine("Reintoarcere la meniu(Y/n): ");
                    sec = Console.ReadLine();
                } while (sec == "Y" || sec == "y");
            }
        }
}