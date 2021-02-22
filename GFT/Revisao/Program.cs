using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto banana = new Produto("Banana", 0.99, 2);
            Produto energetico = new Produto("Energetico", 5.49, 3);
            Produto arroz = new Produto("Arroz", 20, 1);
            Produto chocolate = new Produto("Chocolate", 4.5, 1);
            Produto leite = new Produto("Leite", 3.73, 3);
            Produto abacaxi = new Produto("Abacaxi", 2.40, 2);

            Caixa caixa = new Caixa();
            Console.WriteLine(banana.nome + " = "+ caixa.calculaValorFinal(banana, 3));
            Console.WriteLine(energetico.nome + " = " + caixa.calculaValorFinal(energetico, 7));
            Console.WriteLine(arroz.nome + " = " + caixa.calculaValorFinal(arroz, 1));
            Console.WriteLine(chocolate.nome + " = " + caixa.calculaValorFinal(chocolate, 20));
            Console.WriteLine(leite.nome + " = " + caixa.calculaValorFinal(leite, 3));
            Console.WriteLine(abacaxi.nome + " = " + caixa.calculaValorFinal(abacaxi, 4));
        }

       
    }
}
