using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio4
{
    public class COFINS : Imposto
    {
        public double calculaImposto(double valor)
        {
            if (valor > 12000)
                return valor * 0.08;
            else
                return 0;
        }
    }
}
