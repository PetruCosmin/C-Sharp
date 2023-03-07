using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaStudent
{
    internal class DateUniv
    {
        public string Specializarea;
        public int AnStudiu;
        public string Date_;
        
        public DateUniv(string specializarea, int anStudiu, string Date)
        {
            this.Specializarea = specializarea;
            this.AnStudiu = anStudiu;
            this.Date_ = Date;
        }
        public void setspecializarea(string specializarea) { this.Specializarea = specializarea; }
        public string getspecializarea() { return Specializarea; }
        public void setanStudiu(int anStudiu) { this.AnStudiu = anStudiu; }    
        public int getAnStudiu() { return AnStudiu; }   
        public void setDate(string Date) { this.Date_ = Date; }
        public string getDate() { return Date_; }

        

    }
}
