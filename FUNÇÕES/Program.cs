using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace aula
{
    class Program
    {
        public int Calcular2()
        {
            int a = 1;
            int b = 2;
            int c = a + b;    
            return c;
        }
        public static int Calcular()
        {
            int a = 1;
            int b = 2;
            int c = a + b;    
            return c;
        }
        public static void MostrarMensagemNaTela()
        {   

            Console.WriteLine("Ola");
        }
        public static void Tabuada(int numero)
        {
            Console.WriteLine("=========================");
            for(int i = 1; i<=10; i++)
            {
                Console.WriteLine(numero + " x " + i + " = " + (numero*i));
            }
            Console.WriteLine("=========================");
        }
        static void Main(string[] args)
        {
            int retorno = Calcular();
            Console.WriteLine(retorno);

            MostrarMensagemNaTela();

            Tabuada(1);
            Tabuada(2);
            Tabuada(3);
            Tabuada(4);
            Tabuada(5);
            Tabuada(6);
            Tabuada(7);
            Tabuada(8);
            Tabuada(9);
            Tabuada(10);

        }        
    }    
}
