using System;
using System.Globalization;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int saldo = 1000;

            Console.WriteLine("Bem Vindo ao Caixa!");
            Console.WriteLine(" ");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Endereço: ");
            string endereço = Console.ReadLine();
            Console.Write("Telefone: ");
            string telefone = Console.ReadLine();
            Console.WriteLine(" ");

            Console.WriteLine("Seja Bem vindo " + nome);
            Console.WriteLine(" ");

            Console.WriteLine("    1 - Dados  ");
            Console.WriteLine("    2 - Depositar  ");
            Console.WriteLine("    3 - Sacar  ");
            Console.WriteLine("    0 - Sair  ");

            Console.WriteLine(" ");

            Console.WriteLine("Digite sua opção: "); 

            int x;
                x = int.Parse(Console.ReadLine());
            
    
                while ( x > 0){
                    if (x == 1){
                    Console.WriteLine("Nome: " + nome);
                    Console.WriteLine("Endereço: " + endereço);
                    Console.WriteLine("Telefone: " + telefone);
                    Console.WriteLine("Saldo: " + saldo);

                    Console.WriteLine(" ");

                    Console.WriteLine("Digite sua opção: ");

                    Console.WriteLine("    1 - Dados  ");
                    Console.WriteLine("    2 - Depositar  ");
                    Console.WriteLine("    3 - Sacar  ");
                    Console.WriteLine("    0 - Sair  ");

                    x = int.Parse(Console.ReadLine());
                    
                                    
                }
                    else if (x == 2) {
                    Console.WriteLine("Saldo Atual : " + saldo);
                    Console.WriteLine("Quanto você quer depositar?");
                    Console.Write("Digite o valor: ");
                    int valor = int.Parse(Console.ReadLine());

                    saldo = saldo + valor;

                    Console.WriteLine("Saldo Atual : " + saldo);

                    Console.WriteLine(" ");

                    Console.WriteLine("Digite sua opção: ");

                    Console.WriteLine("    1 - Dados  ");
                    Console.WriteLine("    2 - Depositar  ");
                    Console.WriteLine("    3 - Sacar  ");
                    Console.WriteLine("    0 - Sair  ");

                    x = int.Parse(Console.ReadLine());


                }  
                    else if(x == 3)   {                  
                    Console.WriteLine("Quanto você quer sacar?");
                    Console.Write("Digite o valor: ");
                    int sacar = int.Parse(Console.ReadLine());

                    Console.WriteLine("Saldo Atual: " + saldo);

                    saldo = saldo - sacar;

                    Console.WriteLine("Saldo Atual : " + saldo);
                    Console.WriteLine("Valor retirado : " + sacar);

                    Console.WriteLine(" ");

                    Console.WriteLine("Digite sua opção: ");

                    Console.WriteLine("    1 - Dados  ");
                    Console.WriteLine("    2 - Depositar  ");
                    Console.WriteLine("    3 - Sacar  ");
                    Console.WriteLine("    0 - Sair  ");

                    x = int.Parse(Console.ReadLine());
                    }

                }
                Console.WriteLine("Programa encerrado!!!");
        }
    }
}
