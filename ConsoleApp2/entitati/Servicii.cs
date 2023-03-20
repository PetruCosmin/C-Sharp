using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitati
{
    public class Servicii: ProdusAbstract
    {
        private string? id;
        private string? nume;
        private string? codintern;

        public  Servicii(string? id, string? nume, string? codintern): base(id, nume, codintern )
        {
         
        }
        public override string Descriere()
        {
            return "Produsul: " + this.Nume + "[" + this.Codintern + "] " + this.Id;

        }

        public override string AltaDescriere()
        {
            return "Produsul: " + base.AltaDescriere();
        }
       
    }
}
