﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_10_LISTA_1_Yohan_Aquino
{
    class Program
    {
        static void Main(string[] args)
        {
            /*11. Entrar com o peso e a altura de uma determinada pessoa. Após a digitação, exibir se esta
pessoa está ou não com seu peso ideal. Veja tabela da relação peso/altura².
Relação peso/altura² (R) Mensagem
R < 20 Abaixo do peso
20 <= R < 25 Peso ideal
R >= 25 Acima do peso*/

            IMC imc = new IMC();
            //IMC imc = new IMC(80, 1.71);

            Console.WriteLine("Digete o peso da pessoa:");
            imc.setPeso(double.Parse(Console.ReadLine()));

            Console.WriteLine("Digite a altura da pessoa");
            imc.setAltura(double.Parse(Console.ReadLine()));
            imc.calcularRelação();
            Console.WriteLine("o IMC da pessoa mostra que está {0}",imc.getRelação());
            Console.ReadKey();
        }
    }
}
