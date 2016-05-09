using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InverteVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            // int vo[10];
            // var vo: [Int]

            ///// DECLARAÇÃO DE VARIÁVEIS
            int[] vo = new int[10];           

            ////// ENTRADA DE DADOS
            for (int i = 0; i < vo.Length; i++)
            {
                Console.Write("Informe o numero {0}: ", i + 1);
                vo[i] = Convert.ToInt32(Console.ReadLine());
            }

            /////// PROCESSAMENTO
            for (int i = 0; i < 5; i++)
            {
                int temp = vo[i];
                vo[i] = vo[9 - i];
                vo[9 - i] = temp;
            }


            /////// APRESENTANDO RESULTADOS
            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine("O: {0}", vo[i]);
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("I: {0}", vo[i]);
            }

        }
    }
}
