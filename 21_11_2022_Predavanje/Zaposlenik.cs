using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_11_2022_Predavanje
{
    internal class Zaposlenik
    {
        private int brojZaposlenika;
        private double placaZaposlenika;

        public int BrojZaposlenika
        {
            get { return brojZaposlenika; }
            set
            {
                brojZaposlenika = value;
            }
        }
        public double PlacaZaposlenika
        {
            get { return placaZaposlenika; }
            set
            {
                if (value < 17 || value > 300)
                {
                    placaZaposlenika = 17;
                    NedozvoljenUnos nedozvoljenUnos = new NedozvoljenUnos();
                    throw nedozvoljenUnos;
                }
                
                    placaZaposlenika = value;
            }
        }
        public Zaposlenik(int broj, double placa)
        {
            this.BrojZaposlenika = broj;
            this.PlacaZaposlenika = placa;         
        }   
    }
    class NedozvoljenUnos : Exception
    {
        
        public NedozvoljenUnos() : base("Nedozvoljena plaća")
        {
        }
    }
            
}
