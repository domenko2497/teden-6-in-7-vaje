namespace teden_6_vaja_3
{
    internal class Program
    { 
        static void Main(string[] args)
        {
          pes pes1 = new pes("Floki", 10);
            Console.WriteLine($" {pes1.Ime} je bil {pes1 .Starost} let star.");
        
            pes1.KreirajZvok();

           pes1.Igra();
            pes1.Eat();
            



        }
    }
}
