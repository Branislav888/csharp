namespace OpakovanieLINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Kniha> knihas = new List<Kniha>()
           
            {
                new Kniha() { Autor = "Joanne K. Rowling", rokVydania = 2019, PreDospelych = false },
                new Kniha() { Autor = "Jack Carr", rokVydania = 2022, PreDospelych = true },
                new Kniha() { Autor = "Collen Hooverova", rokVydania = 2023, PreDospelych = true },
           
             };

            List<Kniha> predeti = knihas.Where(kniha => kniha.PreDospelych == false).ToList();

            foreach (Kniha kniha in predeti)
            {
                Console.WriteLine($"LINQ:Kniha napisana {kniha.Autor} je urcena pre deti");
            }
        }
    }
}