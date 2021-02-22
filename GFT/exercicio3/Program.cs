using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Digite um numero: ");
            numero = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Divisivel por: ");
            if(numero % 3 == 0)
            {
                Console.Write("3 ");
            }
            if(numero % 6 == 0)
            {
                Console.Write("6 ");
            }
            if(numero % 7 == 0)
            {
                Console.Write("7 ");
            }

        }
    }
}
