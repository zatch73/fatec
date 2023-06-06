using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace agregracaoVenda
{
    public class Venda
    {
        public Comprador Comprador { get;}
        public Vendedor Vendedor { get;}
        public List<Produto> Produtos { get;}

        public Venda(Comprador Comprador, Vendedor Vendedor, List<Produto> Produtos){
            this.Comprador = Comprador;
            this.Vendedor = Vendedor;
            this.Produtos = Produtos;

            foreach(Produto produto in Produtos){
                Comprador.Verba -= produto.Preco;
                Vendedor.Comissao += produto.Preco * 0.02;
            }
        }

        public void MostrarAtributos(){
            System.Console.WriteLine("\nCOMPRADOR");
            System.Console.WriteLine("Nome: " + Comprador.Nome);
            System.Console.WriteLine("Verba: " + Comprador.Verba);
            System.Console.WriteLine("\nVENDEDOR");
            System.Console.WriteLine("Nome: " + Vendedor.Nome);
            System.Console.WriteLine("Comissao: " + Vendedor.Comissao);
            System.Console.WriteLine("\nPRODUTOS");
            foreach(Produto produto in Produtos){
                System.Console.WriteLine("Nome: "+produto.Nome);
                System.Console.WriteLine("Preco: "+produto.Preco);
            }
        }


    }
}