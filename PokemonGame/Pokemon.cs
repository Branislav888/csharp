using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame
{
    public class Pokemon
    {
        public string Meno { get; set; }
        public int Health { get; set; }

        public Pokemon(string meno, int health)
        {
            this.Meno = meno;
            this.Health = health;
        }
        public int Attack1()
        { 
            Random random = new Random();
            return random.Next(10, 91);

        }
        public int Attack2()
        {
            Random random = new Random();
            return random.Next(30, 71);
        }
        public int Attack3()
        {
            Random random = new Random();
            return random.Next(40, 61);
        }
        public int Heal()
        {
            Random random = new Random();
            int healValue = random.Next(10, 91);
            healValue += healValue;
            if (Health > 100)
            {
                Health = 100;
            }
            return healValue;
        }
    }
}
