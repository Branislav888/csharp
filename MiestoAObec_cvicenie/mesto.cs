using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiestoAObec_cvicenie
{
    public class Mesto
    {
        public string nazov;
        public List<Obcan> Obcania;

        public Mesto(string nazov) 
        {
          this.nazov = nazov;
          Obcania = new List<Obcan>(); 

        }

        public void PridajObcana(Obcan obcan)
        {
            Obcania.Add(obcan);
        }

        public void VypisObcanov()
        {
            Console.WriteLine("Ocania mesta" + nazov);
            foreach (var obcan in Obcania)
            {
                obcan.VypisInfo();
            }

        }
    }   

    
}
