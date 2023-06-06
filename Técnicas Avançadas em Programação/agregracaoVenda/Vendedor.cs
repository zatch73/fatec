using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace agregracaoVenda
{
    public class Vendedor
    {
        public String Nome { get; set; }

        public Double Comissao { get; set; }

        public Vendedor(String nome){
            this.Nome = nome;
        }

        public void MostrarAtributos(){
            System.Console.WriteLine("Nome: " + this.Nome);
            System.Console.WriteLine("Comissao: " + this.Comissao);
        }
    }
}