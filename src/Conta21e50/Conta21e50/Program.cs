using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta21e50
{
    class Program
    {
        static void Main(string[] args)
        {
            int conta21 = 0, conta50 = 0;
            int idade = 0;

            while (idade != -99)
            {
                Console.Write("Informe uma nova idade: ");
                idade = Convert.ToInt32(Console.ReadLine());

                if (idade >= 0)
                {
                    if (idade < 21)
                        conta21++;
                    else if (idade > 50)
                        conta50++;
                }
            }

            Console.WriteLine("Total < 21: " + conta21);
            Console.WriteLine("Total > 50: " + conta50);

        }
    }
}
