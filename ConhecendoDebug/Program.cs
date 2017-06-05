using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConhecendoDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).ExecutarPrograma();
            
        }

        int LerInteiro()
        {
            Console.Write("Digite um numero: ");
            return int.Parse(Console.ReadLine());
        }

        int Somar(int numero1, int numero2)
        {
            int resultado = numero1 + numero2;
            return resultado;
        }

        void ExecutarPrograma()
        {
            int numero1 = LerInteiro();
            int numero2 = LerInteiro();
            int soma = Somar(numero1, numero2);
            Console.WriteLine("O Resultado é {0}", soma);
        }
    }
}
