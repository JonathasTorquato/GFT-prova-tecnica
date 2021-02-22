using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio4
{
    public class ICMS:Imposto
    {
        public double calculaImposto(double valor)
        {
            return valor * 0.3;
        }
    }
}
