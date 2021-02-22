using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio1
{
    public class Produto
    {
        public string nome;
        public double valor;
        public int tipo;
        public Produto(string nome, double valor, int tipo)
        {
            this.nome = nome;
            this.valor = valor;
            this.tipo = tipo;
        }
    }
}
