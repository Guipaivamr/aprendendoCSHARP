using System;
using System.Collections.Generic;

namespace Programação_orientada_a_função
{
    class Program
    {
        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVO = 1;
        public const int TABUADA = 2;
        public const int CALCULO_MEDIA = 3;

        public static void tabuada(int numero)
        {
            Console.WriteLine("=======Calculo da tabuada do " + numero + "==============");
            for(int i = 1;i<= 10; i++)
            {
                Console.WriteLine(numero + " x " + i + " = " + (numero*i));
            }
        }
        public static void CalcularMediaAluno()
        {
            Console.Write("Digite o nome do aluno:");
            string nome = Console.ReadLine();
            int qtdNotas = 3;
            Console.WriteLine("Digite as " + qtdNotas + " notas do Aluno");
            
            List<int> notas = new List<int>();
            int totalNotas = 0;
            for(int i=1; i<= qtdNotas; i++)
            {
                Console.WriteLine("Digite a nota numero " + i);
                int nota = int.Parse(Console.ReadLine());
                totalNotas += nota;
                notas.Add(nota);

            }
            int media = totalNotas / notas.Count;
            Console.WriteLine("A media do aluno " + nome + " é: " + media);
            Console.WriteLine("Suas notas são: \n");
            foreach(int nota in notas)
            {
                Console.WriteLine("NOTA: " + nota + "\n");
            }
        }
        static void Main(string[] args)
        {
            int valor = 1;
            while(valor != 0)
            {   
                string mensagem = "Olá usuario, bem vindo ao programa" +
                    "\n  utilizando programação funcional" +
                    "\n"+
                    "\n      Digite uma das opções abaixo:" +
                    "\n      0 - Sair do Programa" +
                    "\n      1 - Para ler arquivos"+
                    "\n      2 - Para executar a tabuada "+
                    "\n      3 - Calcular média de alunos";

                Console.WriteLine(mensagem);
                
                valor = int.Parse(Console.ReadLine());
                switch (valor)
                {
                case SAIDA_PROGRAMA:
                
                    break;
                
                case LER_ARQUIVO: 
                
                    Console.WriteLine("  ");
                    Console.WriteLine("==========Opção Ler Arquivo=============");
                    Console.WriteLine("Qualquer arquivo"); 
                    Console.WriteLine("  ");
                    break;
                
                case TABUADA:
                
                    Console.WriteLine("  ");
                    Console.WriteLine("==========Opção Tabuada=============");
                    Console.WriteLine("Digite o numero que deseja na tabuada:");
                    int numero = int.Parse(Console.ReadLine());
                    tabuada(numero);
                    Console.WriteLine("  ");
                    break;
                case 3:
                    Console.WriteLine("  ");
                    Console.WriteLine("==========Opção Calculo da Media=============");
                    CalcularMediaAluno();
                    Console.WriteLine("  ");
                    break;
                
                default:
                    Console.WriteLine("  ");
                    Console.WriteLine("Opção invalida");
                    break;
                }
            }
        }
    }
}


