using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingVSUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Boxing

            //Value Type
            int inteiro1 = 2;
            //Reference Type
            object objeto = inteiro1;
            //armazena a variavel da memoria stack para a heap
            Console.WriteLine("Valor do objeto {0}", objeto);
            Console.ReadKey();

            //Unboxing
            int inteiro2 = (int)objeto;//inteiro para objeto deve ser passado por cast
            Console.WriteLine("Valor de inteiro2 = {0}", inteiro2);
            Console.ReadKey();

        }
    }
}
