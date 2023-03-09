namespace ConsoleApp1

{
    class Program
    {

        static void Main(string[] args)
        {
            string D;
            Date Date1 = new Date();
                Student stud1 = new Student();
                stud1.Id = 1;
                stud1.Name = "Student1";
            Date1.spe = "TI";
            D = Date1.spe;
            stud1.DateUniv =D;

                Console.WriteLine("Id ul studentului este: {0}", stud1.Id);
                Console.WriteLine("Numele studentului: {0}", stud1.Name);
                Console.WriteLine("Datele studentului: {0}", stud1.DateUniv);
        }
        }
}