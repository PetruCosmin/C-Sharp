using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitati
{
    public class Produs
    {
        private uint id;// identificator
        private String? nume;// numele produsului
        private String? codIntern;// codul Intern
        private String? producator;// producator

        public Produs(uint id, string? nume, string? codIntern, string? producator)
        {
            this.id = id;
            this.nume = nume;
            this.codIntern = codIntern;
            this.producator = producator;
        }

        public static void Pro(Produs[] produse,uint nrProduse)
        {
            Console.WriteLine("============================");
            Console.WriteLine("Produsele sunt:");
            for (int cnt = 0; cnt < nrProduse; cnt++)
            {
                Produs prod = produse[cnt];
                Console.WriteLine("\nProdus: " + prod.nume +"\nCod intern:[" + prod.codIntern + "] \nProducator:" + prod.producator);
            }
        }
    }
}
