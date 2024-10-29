using System.Collections.Generic;

namespace MiestoAObec_cvicenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mesto mesto1 = new Mesto(nazov: "Bratislava");
            Mesto mesto2 = new Mesto(nazov: "Zilina");
            Povolanie praca1 = new Povolanie(nazov: "Lekar" + ",kt. lieci ludi");
            Povolanie praca2 = new Povolanie(nazov: "Programator" + ",kt. pracuje na PC");


            mesto1.PridajObcana(new Obcan(meno: "Peter", vek: 27, praca1)) ;
            mesto1.PridajObcana(new Obcan(meno: "Jana" , vek: 25, praca2));

            mesto2.PridajObcana(new Obcan(meno: "Sona", vek: 17, praca1));
            mesto2.PridajObcana(new Obcan(meno: "Alica", vek: 19, praca2));

            mesto1.VypisObcanov();
            mesto2.VypisObcanov();
        }

       

    }
}