using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Date
    {
        public Date() { }

        public string studspe;
        public string spe
        {
            get { return studspe; }
            set { studspe = value; }
        }

        public static implicit operator string(Date v)
        {
            throw new NotImplementedException();
        }
    }
}
