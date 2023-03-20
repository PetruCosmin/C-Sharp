using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitati
{
    public class Produs: ProdusAbstract    //dam referinta clasa produs...
    {
        private string? id;// identificator
        private String? nume;// numele produsului
        private String? codIntern;// codul Intern
        private String? producator;// producator

        public Produs(string? id, string? nume, string? codIntern, string? producator): base (id, nume, codIntern)      //mostenire din clasa Produs
        {
           
            this.producator = producator;
        }

        public string? Producator { get => producator; set => producator = value; }


        public override string Descriere()
        {
            return "Produsul: " + this.Nume + "[" + this.Codintern + "] " + this.Producator;

        }

        public override string AltaDescriere()
        {
            return "Produsul: " + base.AltaDescriere() + this.Producator;
        }

        

    }
}
