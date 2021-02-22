namespace exercicio1
{
    public class Caixa{
        public Caixa(){}
        public double calculaValorFinal(Produto produto, int quantidade){
            double pagar = produto.Valor * quantidade;
            if(produto.Tipo == 1 || (produto.Tipo == 3 && quantidade > 5)){
                return pagar -= (pagar * 0.1);
            }else if(produto.Tipo == 2)
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