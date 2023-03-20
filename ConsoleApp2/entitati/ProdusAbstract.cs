using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitati
{
    public abstract class ProdusAbstract
    {
        string? id;
        string? nume;
        string? codintern;

        public string? Id { get => id; set => id = value; }
        public string? Nume { get => nume; set => nume = value; }
        public string? Codintern { get => codintern; set => codintern = value; }


        public ProdusAbstract(string? id, string? nume, string? codIntern)
        {
            Id = id;
            Nume = nume;
            Codintern = codIntern;
        }
        public abstract string Descriere();   //creare metoda descriere
        public virtual string AltaDescriere()
        {
            return this.Nume + "[" + this.Codintern + "] ";
        }
    }
}
