using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroCliente
{
    struct Dependente
    {
        public String Nome;
    }
    struct Cliente {
        public String Nome;
        public String Endereco;

        public Dependente[] Dependentes;
    }

    class Program
    {

        static void Main(string[] args)
        {
            Cliente c = new Cliente();
            c.Nome = "Cliente 1";

            Cliente[] clientes = new Cliente[2];
            for (int i = 0; i < clientes.Length; i++)
            {
                Console.WriteLine("Cadastrando Cliente {0} >>>>>>>>>>", i + 1);

                Console.Write("Informe o nome: ");
                clientes[i].Nome = Console.ReadLine();

                Console.Write("Informe o endereço: ");
                clientes[i].Endereco = Console.ReadLine();

                Console.Write("Informe o número de dependentes: ");
                int qtdDep = Convert.ToInt32(Console.ReadLine());
                Dependente[] deps = new Dependente[qtdDep];

                for (int d = 0; d < deps.Length; d++)
                {
                    Console.Write("Informe o nome do dependente {0}: ", d + 1);
                    deps[d].Nome = Console.ReadLine();
                }
                
                clientes[i].Dependentes = deps;
            }

            Console.WriteLine("Mostrando dados >>>>>>>>>>>>>>>");
            for (int i = 0; i < clientes.Length; i++)
            {
                Console.WriteLine("Cliente {0}: {1}", i + 1, clientes[i].Nome);
                Dependente[] deps = clientes[i].Dependentes;
                for (int d = 0; d < deps.Length; d++)
                {
                    Console.WriteLine("Dependente {0}: {1}", d + 1, deps[d].Nome);
                }
            }
        }
    }
}
