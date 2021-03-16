using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoPalestra
{
    public class Gestiohne
    {
        public static double tariffamigliore(int a)
        {
            //12 mesi 79,99 euro
            //3 mesi 99,99 euro
            // 1 Mese 115,99 euro
            if (a > 1 && a < 3) 
            {
                return"La scelta migliore è quella di un mese";
                double t = a * 115.99;
                return t;
            }
            else if (a > 4 && a < 12)
            {
                return"La scelta migliore è quella di tre mesi";
                double t = a * 99.99;
                return t;
            }
            else
            {
                return"La scelta migliore è quella di dodici mesi";
                double t = a * 79.99;
                return t;
            }
        }
    }
}
