using entitati;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class ServiciiMgr
    {
        private Servicii[] serviciis = new Servicii[100];

        public uint CountServicii { get; set; }=0;

        public void ReadServ()
        {
            Console.WriteLine("Introdu un serviciu:");
            Console.Write("Numele:");
            string Nume = Console.ReadLine();
            Console.Write("Codul intern:");
            string CodIntern = Console.ReadLine();
            Console.Write("Id:");
            string id = Console.ReadLine();
            Servicii servici = new Servicii(id, Nume, CodIntern);

            serviciis[CountServicii++] = servici;
        }

        public void ReadServicii(uint nr) {


            for (int serv = 0; serv < nr; serv++)
            {

                // instantierea unui Produs
                Console.WriteLine("Introdu un serviciu:");
                Console.Write("Numele:");
                string Nume = Console.ReadLine();
                Console.Write("Codul intern:");
                string CodIntern = Console.ReadLine();
                Console.Write("Id:");
                string id = Console.ReadLine();
                Servicii servici = new Servicii(id, Nume, CodIntern);

                serviciis[CountServicii++] = servici;
            }
            
}
        public void WriteServicii()
        {
            Console.WriteLine("============================");
            Console.WriteLine("Serviciile sunt:");
            for (int serv = 0; serv < CountServicii; serv++)
            {
                Servicii servici = serviciis[serv];
                Console.WriteLine("\nServici: " + servici.Nume + "\nCod intern:[" + servici.Codintern + "] \nId:" + servici.Id);
            }
        }
        
        
}
}
