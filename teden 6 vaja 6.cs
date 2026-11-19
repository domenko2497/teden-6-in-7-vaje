namespace teden_6_vaja_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // primer 1
            /* string[] lines = { "prva vrstica", "druga vrstica", "tretja vrstica" };
             File.WriteAllLines(@"C:\Users\Uporabnik\Desktop\Nov Dokument z besedilom.txt", lines);*/
            // primer 2
            /*Console.WriteLine("Dajte naziv fajlu");
            string fileName = Console.ReadLine();
            Console.WriteLine("Dajte text za fajl");
            string input = Console.ReadLine();
            File.WriteAllText(@"C:\Users\Uporabnik\Desktop\Nov Dokument z besedilom.txt" + fileName + ".txt", input);
        */
            // primer 3
            string[] lines = { "prva vrstica", "druga vrstica", "tretja vrstica" };
            using (StreamWriter file = new StreamWriter(@"C:\Users\Uporabnik\Desktop\Nov Dokument z besedilom.txt"))
            {
                foreach (string line in lines)
                {
                    if (line.Contains("druga"))
                    {
                        file.WriteLine(line);
                    }
                }
            }
            using (StreamWriter file = new StreamWriter(@"C:\Users\Uporabnik\Desktop\Nov Dokument z besedilom.txt", true))
            {
                file.WriteLine("Dodatna vrstica");
            }
            Console.ReadKey();

        }
    }
}
