using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hadyARebriky
{
    public class Rebrik
    {
        public int Start { get; set; }
        public int End { get; set; }

        public Rebrik(int start, int end)
        {
            Start = start;
            End = end;
        }

        public int Skontroluj(int pozicia)
        {
            if (pozicia == Start)
            {
                Console.WriteLine($"Super prešiel si z polička {Start} na {End} pomocou rebríku");
                return End;
            }
            return pozicia;

        }
    }
}
