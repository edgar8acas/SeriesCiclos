using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriesCiclos
{
    static class Series
    {
        public static double Seno(int x, int rep)
        {
            double seno = 0;
            for (int i = 1; i <= rep; i++)
            {
                if(i % 2 == 1)
                {
                    seno += Math.Pow(x, (2 * i) - 1) / factorial(2 * i - 1); 
                } else
                {
                    seno -= Math.Pow(x, (2 * i) - 1) / factorial(2 * i - 1);
                }
            }
            return seno;
        }

        private static double factorial(int n)
        {
            double fact = 1;
            for (double i = 1; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        }

        public static double Coseno(int x, int rep)
        {
            double coseno = 1;
            for (int i = 1; i < rep; i++)
            {
                if (i % 2 == 1)
                {
                    coseno -= Math.Pow(x, (2 * i)) / factorial(2 * i);
                }
                else
                {
                    coseno += Math.Pow(x, (2 * i)) / factorial(2 * i);
                }
            }
            return coseno;
        }

        public static double Ln(double x, int rep)
        {
            double ln = 1;
            double z = Math.Pow(99/100, 1);
            for (double i = 1; i <= rep; i++)
            {
                ln += (1 / i) * Math.Pow((x - 1) / x, i); 
            }
            return ln;
        }

        
    }
}
