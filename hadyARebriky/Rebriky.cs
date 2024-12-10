using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hadyARebriky
{
    public class Rebriky
    {
        Random random = new Random();
        public int Rebrik()
        {
            int number = random.Next(2,5);
            Console.WriteLine($"Pusunieš sa o : {number} polička");
        }

    }
}
