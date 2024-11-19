namespace TimOPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tim tim = new Tim();

            tim.PocetT = (5);
            tim.nazov = "ziaci";

            Console.WriteLine("Pocet:" + tim.PocetT);
            Console.WriteLine("Nazov:" + tim.nazov);
        }
    }
}