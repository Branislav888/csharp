using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiestoAObec_cvicenie
{
    public class Obcan
    {
        public string obcan { get; set; }
        public int vek { get; set; }
      
        public Obcan()
        {
            List<Obcan> list = new List<Obcan>();
            Obcan Peter = new Obcan(); vek = 30;
            Obcan Jana = new Obcan(); vek = 45;
            Obcan Sona = new Obcan(); vek = 19;
            Obcan Alica = new Obcan(); vek = 37;
        }

        

        
    }
}
