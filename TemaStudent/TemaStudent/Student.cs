using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaStudent
{
    internal class Student
    {
        //
        
            public string Nume;
            public int Id;
            public string Prenume;
            public string Adresa;
            public string Date_Univ;

            // constructor
            public Student(string name, int ID, string prenume, string adresa, string dateUniv)
            {
                this.Nume = name;
                this.Id = ID;
                this.Prenume = prenume;
                this.Adresa = adresa;
                this.Date_Univ = dateUniv;

            }
            // setters
            public void setName(string name) { this.Nume = name; }
            public void setID(int ID) { this.Id = ID; }
            public void setCourse(string prenume) { this.Prenume = prenume; }
            public void setStream(string adresa) { this.Adresa = adresa; }
            public void setdateUniv(string dateUniv) { this.Date_Univ = dateUniv; }
            
        public string getdateUniv() { return Date_Univ; }
        public string getName() { return Nume; }
        public int getID() { return Id; }
        public string getprenume() { return Prenume; }
        public string getadresa() { return Adresa; }
    }
}
