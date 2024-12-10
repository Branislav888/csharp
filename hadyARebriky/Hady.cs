using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hadyARebriky
{
    public class Hady
    {
        Random random = new Random();
        public int Hady()
        {
            int number = random.Next(2, 5);
            Console.WriteLine($"Ideš o  : {number} polička nižšie");
        }

    }
}
