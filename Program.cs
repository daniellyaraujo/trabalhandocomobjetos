using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalhandocomobjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada = "";
            Pessoa Pessoa1;
            Pessoa1 = new Pessoa();
            Console.WriteLine("Efetua a leitura dos dados de tres pessoas");
            Console.WriteLine("Dados da 1 pessoa");
            Console.WriteLine("Informe seu nome: ");
            entrada = Console.ReadLine();
            Pessoa1.nome = entrada;
            Console.WriteLine("Informe sua altura: ");
            entrada = Console.ReadLine();
            Pessoa1.altura = Convert.ToDouble(entrada);
            Pessoa1.faleSobreVoce();
            Console.ReadKey();
        }
    }
}
