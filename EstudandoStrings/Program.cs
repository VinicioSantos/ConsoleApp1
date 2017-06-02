using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudandoStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string string1 = "abc";
            string string2 = "def";
            StringBuilder sb = new StringBuilder();

            sb.Append(string1);
            sb.Append(" ");
            sb.Append(string2);
            sb.Append(" ");

            Console.WriteLine("{0}", sb.ToString());
            Console.ReadKey();
            */

            //conversão Explicita
            /*
            int i;
            double y = 10.5;
            i = (int)y;

            Console.WriteLine("O valor 10.5 em inteiro é " + i);//na conversão o valor foi truncado na parte decimal
            Console.ReadKey();
            */

            //Conversão Implicita
            long x;
            int y = 5;
            x = y;

            Console.WriteLine("O valor 5 em long é " + x);
            Console.ReadKey();

        }
    }
}
