using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace agregracaoVenda
{
    public class Comprador
    {
        public String Nome { get; set; }
        public Double Verba { get; set; }

        public Comprador(String nome, Double verba){
            this.Nome = nome;
            this.Verba = verba;
        }

        public void MostrarAtributos(){
            System.Console.WriteLine("Nome: " + this.Nome);
            System.Console.WriteLine("Verba: " + this.Verba);
        }
    }
}