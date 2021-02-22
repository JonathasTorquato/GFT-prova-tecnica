using System;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor, total;
            ICMS icms = new ICMS();
            IPI ipi = new IPI();
            COFINS cofins= new COFINS();
            Console.WriteLine("Digite um valor: ");
            valor = Int32.Parse(Console.ReadLine());
            Console.WriteLine("ICMS: " + icms.calculaImposto(valor));
            Console.WriteLine("ICMS: " + ipi.calculaImposto(valor));
            Console.WriteLine("ICMS: " + cofins.calculaImposto(valor));
            total = valor + icms.calculaImposto(valor) + ipi.calculaImposto(valor) + cofins.calculaImposto(valor);
            Console.WriteLine("Total: " + total);
        }
    }
}
