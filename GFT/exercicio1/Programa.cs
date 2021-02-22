using System;

namespace exercicio1
{
    public class Programa
    {
        static void Main(string[] args)
        {
            
            public Produto banana = new Produto("Banana", 0.99, 2);
            public Produto energetico = new Produto("Energetico", 5.49, 3);
            public Produto arroz = new Produto("Arroz", 20, 1);
            public Produto chocolate = new Produto("Chocolate", 4.5, 1);
            public Produto leite = new Produto("Leite", 3.73, 3);
            public Produto abacaxi = new Produto("Abacaxi", 2.40, 2);

            public Caixa caixa = new Caixa();
            Console.WriteLine(banana.nome + " = "+ caixa.calculaValorFinal(banana, 3));
             

              
        }
    }
}