using System;
using System.Globalization;

namespace calculadoraApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("NOME: ");
            string nome = Console.ReadLine();
            Console.Write("CIDADE: ");
            string cidade = Console.ReadLine();
            Console.Write("ENDEREÇO: ");
            string endereço = Console.ReadLine();
            Console.Write("NUMERO: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("TELEFONE: ");
            string telefone = Console.ReadLine();
           
            int x, y;
            

            Console.WriteLine("Entrada de saldo");
            x = int.Parse(Console.ReadLine());
            y = x;
            Console.WriteLine("Seu saldo acumulado é " + x);

            while ( y != 0) {               
                Console.WriteLine("Entrada de saldo: ");  
                y = int.Parse(Console.ReadLine());
                x = x + y; 
                Console.WriteLine("Seu saldo acumulado é " + x);
            }
            Console.WriteLine("Entrada de saldo : 0");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Cidade: " + cidade);
            Console.WriteLine("Endereço: " + endereço + " Numero " + numero);
            Console.WriteLine("Telefone: " + telefone);

            Console.WriteLine("Saldo atual: " + x);

        }
    }
}
