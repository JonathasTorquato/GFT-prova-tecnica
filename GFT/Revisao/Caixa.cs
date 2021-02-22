using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio1
{
    class Caixa
    {
        public Caixa() { }
        public double calculaValorFinal(Produto produto, int quantidade)
        {
            double pagar = produto.valor * quantidade;
            if (produto.tipo == 1 || (produto.tipo == 3 && quantidade > 5))
            {
                return pagar -= (pagar * 0.1);
            }
            else if (produto.tipo == 2)
            {
                return pagar -= (pagar * 0.2);
            }
            else
            {
                return pagar;
            }
        }
    }
}
