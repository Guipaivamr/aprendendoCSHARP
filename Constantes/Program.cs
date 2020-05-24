using System;

namespace Constantes
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Digite numero acima de 3 ou 0 para sair do programa");
                int valor = int.Parse(Console.ReadLine());

                if(SAIDA_PROGRAMA == valor)
                {
                    Console.WriteLine("Boa boa boa");
                }
                else if (SAIDA2_PROGRAMA2 == valor)
                {
                    Console.WriteLine("ola meu irmao");
                }
                else if (SAIDA3_PROGRAMA3 == valor)
                {
                    Console.WriteLine("agora so mais um");
                }
                else 
                {
                    break;
                }
            }
        }

        public const int SAIDA_PROGRAMA = 1;
        public const int SAIDA2_PROGRAMA2 = 2;
        public const int SAIDA3_PROGRAMA3 = 3;
    }
}
