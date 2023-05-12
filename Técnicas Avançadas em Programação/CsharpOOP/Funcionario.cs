using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CsharpOOP
{
    public class Funcionario
    {
        public static int Contador { get; set; }
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int Salario { get; set; }

        Funcionario(){
            Nome = "";
            Contador++;
        }

        Funcionario(int codigo, string nome){
            Codigo = codigo;
            Nome = nome;
            Contador++;
        }

        Funcionario(int codigo, string nome, int salario){
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
            Contador++;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Codigo: {Codigo}, Salario: {Salario}";
        }
        
    }
}