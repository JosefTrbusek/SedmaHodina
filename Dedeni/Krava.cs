using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedeni
{
    public class Krava : Zvire
    {
        public int Dojivost;
        public int KravaId;
        public Krava(string jmeno, int dojivost, int kravaId):base(jmeno,200,700)
        {
            Dojivost = dojivost;
            KravaId = kravaId;
        }
        public int DejMleko()
        {
            return 20;
        }
    }
}
