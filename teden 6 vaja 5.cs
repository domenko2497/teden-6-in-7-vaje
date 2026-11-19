namespace teden_6_vaja_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // primer 1
            // IO = input output
           /* string text = System.IO.File.ReadAllText(@"C:\Users\Uporabnik\Desktop\Nov Dokument z besedilom.txt");
            Console.WriteLine("V tekstualnem fajlu imamo naslednjo vsebino: \n{0}", text);*/
            // primer 2
           string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Uporabnik\Desktop\Nov Dokument z besedilom.txt");
            Console.WriteLine("V tekstualnem fajlu imamo naslednjo vsebino: ");
            foreach (string line in lines)
            {
                // kreiranje "tab" + vrstica
                Console.WriteLine("\t" + line);


            }
            Console.ReadKey();
        }
    }
}
