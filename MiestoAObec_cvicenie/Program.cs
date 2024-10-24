using System.Collections.Generic;

namespace MiestoAObec_cvicenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mesto mesto1 = new Mesto(nazov: "Bratislava");
            Mesto mesto2 = new Mesto(nazov: "Zilina");


            mesto1.PridajObcana(new Obcan(meno: "Peter", vek: 27));
            mesto1.PridajObcana(new Obcan(meno: "Jana" , vek: 25));

            mesto2.PridajObcana(new Obcan(meno: "Sona", vek: 17));
            mesto2.PridajObcana(new Obcan(meno: "Alica", vek: 19));

            mesto1.VypisObcanov();
            mesto2.VypisObcanov();
        }

       

    }
}