using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz5x5
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Declaração de variáveis
            int[,] m = new int[5, 5];
            int sL4 = 0, sC2 = 0, sdp = 0, sds = 0, st = 0;

            /// Entrada de dados
            for (int l = 0; l < 5; l++)
            {
                for (int c = 0; c < 5; c++)
                {
                    Console.Write("Informe [{0},{1}]: ", l, c);
                    m[l, c] = Convert.ToInt32(Console.ReadLine());
                }
            }

            /// Processamento dos dados
            for (int l = 0; l < 5; l++)
            {
                for (int c = 0; c < 5; c++)
                {
                    if(l == 4)                        
                        sL4 = sL4 + m[4, c];
                    if (c == 2)
                        sC2 += m[l, 2];

                    if (l == c)
                        sdp += m[l, c];

                    if (l == 4 - c)
                        sds += m[l, c];

                    st += m[l, c];
                }
            }

            Console.WriteLine(
                "SL4: {0}\nSC2: {1}\nSDP: {2}\nSDS: {3}\nST: {4}",
                sL4, sC2, sdp, sds, st);
        }
    }
}
