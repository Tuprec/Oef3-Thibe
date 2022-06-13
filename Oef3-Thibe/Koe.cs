using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef3_Thibe
{
    class Koe : Dier
    {
        private string strRas;
        private string strNaam;
        private string strAantalLiterMelk;

        public Koe()
        {
            strRas = "Onbekent";
            strNaam = "Onbekent";
            strAantalLiterMelk = "Hoeveeleid melk onbekend";
        }
        public string strras  
        {
            get { return strRas; }   
            set { strRas = value; }  
        } 
        public string strnaam  
        {
            get { return strNaam; }   
            set { strNaam = value; }  
        } 
        public string straantalLiterMelk  
        {
            get { return strAantalLiterMelk; }   
            set { strAantalLiterMelk = value; }  
        }
        public override void Geluid()
        {
            Console.WriteLine("De koe loeit");
        }
    }
}
