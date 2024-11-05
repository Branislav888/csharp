using MiestoAObec_cvicenie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiestoAObec_cvicenie

{
    public class mesto
    {
        public string nazov;
        public List<Obcan> obcania = new List<Obcan>();

        public mesto(string nazov)
        {
            this.nazov = nazov;
            obcania = new List<Obcan>();
        }

        public void PridajObcana(Obcan obcan)
        {
            obcania.Add(obcan);
        }
        public void VypisObcana()
        {
            Console.WriteLine("Obcania mesta " + nazov + ":");
            foreach (Obcan obcan in obcania)
            {
                obcan.VypisInfo();
            }
        }
    }
}
