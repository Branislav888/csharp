class TestClass
{
    static void Main(string[] args)
    {



        List<string> listname = new List<string>();


        listname.Add("Branislav");
        listname.Add("Alica");
        listname.Add("Oliver");
        listname.Add("Filip");
        listname.Add("Lucka");
        listname.Add("Sona");
        {
            int counter = 0;

            foreach (string name in listname)
            {
                Console.WriteLine(counter + name.ToUpper());
                counter++;
            }
        }
        

       foreach (string name in listname)
        {
            Console.WriteLine("Zadaj meno:");

        }
        
    }


    


}  
  