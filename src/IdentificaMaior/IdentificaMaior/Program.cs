using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentificaMaior
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Informe a, b e c:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            int maior;
            if (a > b && a > c)
                maior = a;
            else if (b > c)
                maior = b;
            else
                maior = c;

            Console.WriteLine("O maior numero é: " + maior);                
        }
    }
}
