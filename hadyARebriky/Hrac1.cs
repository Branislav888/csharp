using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hadyARebriky
{
    public class Hrac1
    {
        public string Meno { get; set; }
        public int Skore { get; set; }


        public Hrac1(string meno)
        {
            Meno = meno;
            Skore = 0;
        }


        public int (Kocka kocka)
        {
            Random random = new Random();
            int cislo = random.Next(1, 7);
           
        }

       
    }

}