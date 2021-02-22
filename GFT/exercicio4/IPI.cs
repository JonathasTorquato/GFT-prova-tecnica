using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio4
{
    public class IPI:Imposto
    {
        public double calculaImposto(double valor)
        {
            if (valor < 25000)
                return valor * 0.05;
            else
                return valor * 0.1;
        }
    }
}
