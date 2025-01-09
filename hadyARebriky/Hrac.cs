using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hadyARebriky
{
    public class Hrac
    {
        public string Meno { get; set; }
        public int Pozicia { get; set; }


        public Hrac(string meno)
        {
            meno = meno;
            Pozicia = 0;
        }


        public void pohyb (int kocka)
        {
            
           
        }
        public int hodKocky(Kocka kocka)
        {
            throw new NotImplementedException();
        }

    }

}