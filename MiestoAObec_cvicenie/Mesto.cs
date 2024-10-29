using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiestoAObec_cvicenie

public class mesto
{
    public string nazov;
    public List<lekar> lekari = new List<lekar>();
    public List<programator> programatori = new List<programator>();

    public mesto(string nazov)
    {
        this.nazov = nazov;
    }

    public void PridajLekara(Lekar lekar)
    {
        lekari.Add(lekar);
    }

    public void PridajProgramatora(Programator programator)
    {
        programatori.Add(programator);
    }

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
        Console.WriteLine("Ocania mesta" + nazov + ":");
        foreach (Lekar lekar in lekari)
        {
            lekar.VypisInfo();
        }

        foreach (Programator programator in programatori) ;
        {
            programator.VypisInfo();
        }

     

    }
   
}





