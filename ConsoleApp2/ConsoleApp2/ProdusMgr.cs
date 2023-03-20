using entitati;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class ProdusMgr
    {


       private Produs[] produse = new Produs[100];



        public uint CountProduse { get; set; }=0;

        public void ReadProd()
        {
            Console.WriteLine("Introdu un produs");
            Console.Write("ID:");
            string id = Console.ReadLine();


            Console.Write("Numele:");
            string Nume = Console.ReadLine();
            Console.Write("Codul intern:");
            string CodIntern = Console.ReadLine();
            Console.Write("Producator:");
            string Producator = Console.ReadLine();
            Produs prod = new Produs(id, Nume, CodIntern, Producator);

            produse[CountProduse++] = prod;
        }

        public void ReadProduse(uint nr )
            
        {
            for (int cnt = 0; cnt < nr; cnt++)
            {

                // instantierea unui Produs
                Console.WriteLine("Introdu un produs");
                Console.Write("ID:");
                string id = Console.ReadLine();


                Console.Write("Numele:");
                string Nume = Console.ReadLine();
                Console.Write("Codul intern:");
                string CodIntern = Console.ReadLine();
                Console.Write("Producator:");
                string Producator = Console.ReadLine();
                Produs prod = new Produs(id, Nume, CodIntern, Producator);

                produse[CountProduse++] = prod;
            }

        }
        public void WriteProduse()
        {
            Console.WriteLine("============================");
            Console.WriteLine("Produsele sunt:");
            for (int cnt = 0; cnt < CountProduse; cnt++)
            {
                Produs prod = produse[cnt];
                Console.WriteLine("\nProdus: " + prod.Nume + "\nCod intern:[" + prod.Codintern + "] \nProducator:" + prod.Producator);
            }
        }
    }
}
