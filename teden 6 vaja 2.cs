using System;
using System.Collections.Generic;
using System.Text;

namespace TEDEN_6_VAJA_2
{
    internal class TELEFON
    {
        private string znamka;

        private string model;

        private string podjetje;


        public TELEFON()
        {
            this.znamka ="neznano";
            this.model = "neznano";
            this.podjetje = "neznano";



        }
        public TELEFON(string znamka, string model)
        {
            this.znamka = znamka;
            this.model = model;
           



        }
        public TELEFON(string znamka, string model, string podjetje)
        {
            this.znamka = znamka;
            this.model = model;
            this.podjetje = podjetje;



        }

        public void telefon()

        {
            Console.WriteLine("tvoj telefon je " + znamka + "in model " + model + "iz podjetja " + podjetje);
        }



    }
}
