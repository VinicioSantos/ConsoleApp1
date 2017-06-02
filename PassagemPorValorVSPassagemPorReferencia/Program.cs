using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassagemPorValorVSPassagemPorReferencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //passagem por valor
            /*int numero1 = 3;
            int numero2 = numero1;
            numero1 = 5;
            Console.WriteLine("numero1 = {0}, numero2 = {1}",numero1,numero2);
            Console.ReadKey();*/

            /*
            //passagem por referencia
            teste teste1 = new teste(); //armazena na memoria heap
            teste1.Quantidade = 1; //coloca no stack um ponteiro para a area heap
            teste teste2 = teste1; //ponteiro teste2 vai apontar para mesmo espaço de memoria heap que teste1
            teste1.Quantidade = 5;
            Console.WriteLine("teste1.quantidade = {0},teste2.quantidade = {1}", teste1.Quantidade, teste2.Quantidade);
            Console.ReadKey();

            //Tipagem por inferencia
            int inteiro = 4;
            var inteiro1 = 4; //variavel generica, sem explicitar, não recomendado
            Console.WriteLine("inteiro1  = {0}", inteiro1);
            Console.ReadKey();
            //var teste; Vai dar pau
            //Tipagem Dynamic
            dynamic minhaVariavel = 2;
            Console.WriteLine("inteiro + minhaVariavel = {0}", inteiro1 + minhaVariavel);
            minhaVariavel = "Treinamento";
            Console.WriteLine("minhaVariavel = {0}", minhaVariavel);
            Console.ReadKey();
            */



            /*
            teste teste1 = new teste(); //instanciar um objeto chamado teste1 da classe teste
            teste1.Quantidade = 3; //acessando a variavel quantidade pelo objeto teste1
            teste1.testePai = new teste(); //instanciando um objeto testePai dentro do objeto teste1
            teste1.testePai.Quantidade = 6; //acessando a variavel quantidade pelo objeto testePai dentro do objeto teste1
            
            Console.WriteLine("Quantidade é {0}", teste1.Quantidade);
            Console.WriteLine("Quantidade do teste pai = {0}", teste1.testePai.Quantidade);
            Console.ReadKey();
            */


            //Strings
            string s = "Texto"; //string
            Console.WriteLine(s);
            string s1 = " do curso"; 
            Console.WriteLine(s + s1); //concatenando strings
            
            string s2 = s.Substring(0, 3);//primeiro parametro pega a posição e o segundo pega o tamanha que deseja armazenar a partir da posição
            Console.WriteLine(s2);
            Console.ReadKey();
            string pula = "Pula\nString"; //pular linha
            string barra = "ba\\rra"; //colocar barra
            Console.WriteLine(pula); 
            Console.WriteLine(barra);
            Console.ReadKey();
            string ignore = @"ab\ncd";//ignora caracteres especiais
            Console.WriteLine(ignore);
            Console.ReadKey();
        }
    }
    /*
    class teste
    {

        public int Quantidade;
        public teste testePai;
    }
    */
}
