using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hadyARebriky
{
    public class Hrac2
    {
        public string Meno { get; set; }
        public int Skore { get; set; }


        public Hrac2(string meno)
        {
            Meno = meno;
            Skore = 0;
        }


        public int HodKockou(Kocka kocka)
        {
            int hod = kocka.Hod();
            Skore += hod;
            return hod;
        }
    }
}
