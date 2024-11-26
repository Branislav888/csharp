﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiestoAObec_cvicenie
{
    public class Obcan
    {
        protected string meno;
        protected int vek;
        protected StavObcana stav;

        public StavObcana Stav
        {
            get { return stav; }
            set { stav = value; }
        }
       

        public Obcan (string meno, int vek)
        {
            this.meno = meno;
            this.vek = vek;
        }

        public string Meno
        {
            get { return meno; }
            set { meno = value; }

        }
        public int Vek
        {
            get { return vek; }
            set { vek = value; }
        }


        public virtual void VypisInfo()
        {
            Console.WriteLine(" Meno: " + meno +" , Vek: " +  vek + " Stav: " +stav );
        }
    }

    public enum StavObcana
    {
        Domaci,
        Cudzie,
        Turista,
    }
}
