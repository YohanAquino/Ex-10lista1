using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_10_LISTA_1_Yohan_Aquino
{
    class IMC
    {
        private double p;
        private double h;
        private double r;

        public void setPeso(double x) 
        {
            p = x;
        }

        public void setAltura(double x)
        {
            h = x;
        }

        public void calcularRelação() 
        {
            r = p /Math.Pow(h, 2);
        }
        public string getRelação()
        {
            if (r < 20)
            {
                return "abaixo do peso";
            }
            else 
            {
                if (r >= 25)
                {
                    return "acima do peso";
                }
                else 
                {
                     return "no peso ideal";
                }
            }
        }

    }
}
