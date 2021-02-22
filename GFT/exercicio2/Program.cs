using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int inicio = 0, fim = 0;
            
            Console.WriteLine("Insira o inicio: ");
            inicio = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Insira o Fim: ");
            fim = Int32.Parse(Console.ReadLine());
            while(fim - inicio <= 15)
            {
                for(int i = inicio; i <= fim; i++)
                {
                    Console.WriteLine(i + "^ 3 = " + (i * i * i));
                }
                Console.WriteLine("Insira o inicio: ");
                inicio = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Insira o Fim: ");
                fim = Int32.Parse(Console.ReadLine());
            }
        }
    }
}
