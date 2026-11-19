
namespace teden_6_vaja_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Objava objava1 = new Objava("To je prva objava", true, "Domen Gazvoda");
            Console.WriteLine(objava1.ToString());
            ObjavaSlike objavaSlike1 = new ObjavaSlike("To je druga objava",
            "Domen Gazvoda", "https://live.staticflickr.com/6068/6065510171_bb00e7222b_z.jpg", true);
            Console.WriteLine(objavaSlike1.ToString());
            ObjavaVidea objavaVidea1 = new ObjavaVidea("To je tretja objava", "Domen Gazvoda", "https://www.youtube.com/shorts/Dla6Cs9r0IU", true);
            Console.WriteLine(objavaVidea1.ToString());
            Console.ReadLine();
        }


    }
}
