using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiestoAObec_cvicenie
{
    public class SeniorProgramator1 : Programator
    {
        public int pocetProjektov;
        public SeniorProgramator1(string meno, int vek, string programoaciJazyk, string seniorProgramator, int pocetProjektov) :
            base (meno, vek, programoaciJazyk, seniorProgramator)
        {
          this.pocetProjektov = pocetProjektov;
        }
       public new void VypisInfo()
        {
            Console.WriteLine(meno + " , " + " programuje v:" + programovaciJazyk + " a ma " + pocetProjektov + "projektov");
        }
    }
}
