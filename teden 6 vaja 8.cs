using System;

using System.IO;

using System.Collections.Generic;



namespace Parsing

{

    class Program

    {

        static void Main(string[] args)

        {

            List<string> rezultat = new List<string>();




            foreach (string vrstica in File.ReadLines("input.txt"))

            {

                if (vrstica.Contains("split"))

                {

                  

                    string[] deli = vrstica.Split(' ');



              
                    if (deli.Length > 4)

                    {

                        rezultat.Add(deli[4]);

                    }

                }

            }




            File.WriteAllText("output.txt", string.Join(" ", rezultat));



            Console.WriteLine("Podatki so zapisani v output.txt.");

            Console.ReadLine();

        }

    }

}