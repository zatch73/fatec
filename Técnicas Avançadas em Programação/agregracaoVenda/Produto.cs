using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace agregracaoVenda
{
    public class Produto
    {
        public static int Codigo = 500;
        public String Nome { get; set; }
        public Double Preco { get; set; }

        public Produto(String nome, Double preco){
            this.Nome = nome;
            this.Preco = preco;
            Codigo++;
        }

        public void MostrarAtributos(){
            System.Console.WriteLine("Codigo: " + Codigo);
            System.Console.WriteLine("Nome: " + this.Nome);
            System.Console.WriteLine("Preco: " + this.Preco);
        }
    }
}