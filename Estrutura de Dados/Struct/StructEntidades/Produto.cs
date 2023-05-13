using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Struct.StructEntidades
{
    public struct Produto
    {
        private string nome;
        private int id;
        private float valor;
        private int qtde;

        public Produto(string nome, int id, float valor, int qtde){
            this.nome = nome;
            this.id = id;
            this.valor = valor;
            this.qtde = qtde;
        }

        public void aplicarCupomDescontoValor(float desconto){
            this.valor -= desconto;
        }
        public void aplicarCupomDescontoPorcentagem(int desconto){
            float valorDesconto = this.valor - (this.valor*desconto/100);
            this.valor = valorDesconto;
        }
        public string verificarQuantidadeEmEstoque(){
            return "Quantidade em estoque é: " + this.qtde;
        }
        public string imprimir(){
            return "\nNome do produto: "+this.nome+
            "\nId: "+this.id+
            "\nValor: "+this.valor+
            "\nQuantidade: "+this.qtde;
        }
    }
}