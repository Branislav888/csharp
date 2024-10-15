namespace Cvi4enie_OOP_Hra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            {
                player.Name = "B";
                player.HP = 100;
                player.Mana = 8;
                player.AttackPower = 6;
            }
            Player player2 = new Player();
            {
                player2.Name = "H";
                player2.HP = 100;
                player2.Mana = 15;
                player2.AttackPower = 3;
            }
            Console.WriteLine("Zaporna postava HP:" + player2 );
            player.DamagePlayer(player2);
            Console.WriteLine("Zaporna postava HP:" + player2);
            
            int HP = 100;
            while (true)
            {
                if (player.HP > 15)
                {
                    return player.Mana++;
                }
                else if (player2.HP < 10)
                { 
                    return player2.Mana++;
                }
            }


        }
    }
}