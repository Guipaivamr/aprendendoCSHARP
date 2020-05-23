using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;

namespace aula
{
    class Program
    {
        private const string V = ".txt";

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

        private static void LerArquivo(int NumeroArquivo)
        {
            string arquivoComCaminho = @"C:\Users\GUILHERME\Documents\VSCODE\calculadoraApp\FUNÇÕES RECURSIVAS\arq1" + NumeroArquivo + ".txt";
            if (File.Exists(arquivoComCaminho))
            {
               using (StreamReader arquivo = File.OpenText(arquivoComCaminho))
                {
                    string linha;
                    while((linha = arquivo.ReadLine()) != null)
                        {
                            Console.WriteLine(linha);
                        }
                } 
            }
            
        }
        static void Main(string[] args)
        {
            
        }        
    }    
}
