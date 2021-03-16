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
                double b = a * 115.99;
                return b;
            }
            else if (a > 4 && a < 12)
            {
                double b = a * 99.99;
                return b;
            }
            else
            {
                double b = a * 79.99;
                return b;
            }
        }
            public static string tariffamigliore1(int a)
            {
                if (a > 1 && a < 3)
                {
                    string t = "La scelta migliore è quella di un mese";
                    return t;

                }
                else if (a > 4 && a < 12)
                {
                    string t = "La scelta migliore è quella di tre mesi";
                    return t;
                }
                else
                {
                    string t = "La scelta migliore è quella di dodici mesi";
                    return t;
                }
            }
        }
    }
}
