using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TimOPP
{
    public class Tim
    {
        private int PocetT;
        private string nazov;

        public Tim()
        { 
        } 

        public Tim (int PocetT,  string nazov)
        {
            this.PocetT = PocetT;
            this.nazov = nazov;
        }
        public int PocetT
        {
            get { return PocetT; }
            set { PocetT = value; }
        }
        public string nazov
        {
            get { return nazov; }
            set { nazov = value; }
        }
    }      
    
}
