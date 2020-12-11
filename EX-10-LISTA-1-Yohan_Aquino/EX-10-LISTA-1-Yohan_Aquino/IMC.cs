using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_10_LISTA_1_Yohan_Aquino
{
    class IMC
    {
        #region atributos
        private double peso;
        private double altura;
        private double razao;
        #endregion;

        #region construtores
        public IMC() 
        {
            peso = 0;
            altura = 0;
        }

        public IMC(double peso,double altura)
        {
            this.peso = peso;
            this.altura = altura;
        }

        #endregion;

        #region metodos set e get
        public void setPeso(double peso) 
        {
            this.peso = peso;
        }

        public void setAltura(double altura)
        {
            this.altura = altura;
        }

        public string getRelação()
        {
            if (razao < 20)
            {
                return "abaixo do peso";
            }
            else
            {
                if (razao >= 25)
                {
                    return "acima do peso";
                }
                else
                {
                    return "no peso ideal";
                }
            }
        }

        #endregion;

        #region metodos funcionais
        public void calcularRelação() 
        {
            razao = peso /Math.Pow(altura, 2);
        }
        #endregion;

    }
}
