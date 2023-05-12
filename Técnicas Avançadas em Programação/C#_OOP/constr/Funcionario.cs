using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C__OOP
{
    public class Funcionario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int Salario { get; set; }

        Funcionario(int codigo, int nome, int salario){
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Codigo: {Codigo}, Salario: {Salario}";
        }
        
    }
}