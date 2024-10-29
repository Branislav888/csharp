using MiestoAObec_cvicenie;
using MiestoAObec_cvicenie.PovolanoeMenoMesto_cvicenie;
using System.Collections.Generic;

namespace MiestoAObec_cvicenie
{
    public class Program
    {
        mesto bratislava = new mesto(nazov: "Bratislava");
       Lekar lek = new Lekar (meno: "Igor" , vek: 34);
       Programator prog = new Programator (meno: "Igor", vek: 28, programoaciJazyk: "C#");
        SeniorProgramator1 senProg = new SeniorProgramator1(meno: "Martin", vek: 25, pocetProjektov: 25, programoaciJazyk: "Java");

        
    }
}