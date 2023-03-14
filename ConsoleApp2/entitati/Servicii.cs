using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitati
{
    public class Servicii
    {
        private string? id;
        private string? name;
        private string? codintern;

        public Servicii(string? id, string? name, string? codintern)
        {
            this.id = id;
            this.name = name;
            this.codintern = codintern;
        }
        public static void Servi(Servicii[] serviciis, uint nrServicii)
        {
            Console.WriteLine("============================");
            Console.WriteLine("Serviciile sunt:");
            for (int serv = 0; serv < nrServicii; serv++)
            {
                Servicii servici = serviciis[serv];
                Console.WriteLine("\nServici: " + servici.name + "\nCod intern:[" + servici.codintern + "] \nId:" + servici.id);
            }
        }
    }
}
