using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Struct.StructEntidades
{
    public struct Professor
    {
        private string nome;
        private int id;
        private int idade;
        private float cargaHoraria;
        private float diasTrabalhados = 20;
        private float numerosAulas;
        private float salario;
        private int faltas;
        private float valorAula;

        public Professor(string nome, int id, int idade, float cargaHoraria, float valorAula){
            this.nome = nome;
            this.id = id;
            this.cargaHoraria = cargaHoraria;
            this.valorAula = valorAula;
            this.salario = cargaHoraria * valorAula;
            this.numerosAulas = cargaHoraria / 20;
        }

        public void reajusteSalarialEmValor(float valor){
            this.salario += valor;
        }
        public void reajusteSalarialEmPorcentagem(int porcentagem){
            float aumento = this.salario + (this.salario*porcentagem/100);
            this.salario = aumento;
        }
        public void descontoSalarialPorFaltaEmValor(int faltas){
            this.faltas += faltas;
            this.salario -= faltas*this.valorAula;
        }
        public void descontoSalarialPorFaltaEmPorcentagem(int faltas){
            this.faltas += faltas;
            float desconto = this.salario - (this.salario*((this.numerosAulas-faltas)*10)/100);
            this.salario = desconto;
        }
        public void aumentarCargaHorariaDeTrabalho(int aumento){
            this.cargaHoraria += aumento;
            this.numerosAulas = cargaHoraria / 20;
            this.salario = cargaHoraria * valorAula;
            
        }
        public string imprimir(){
            return "\nNome do produto: "+this.nome+
            "\nId: "+this.id+
            "\nCarga Horária: "+this.cargaHoraria+
            "\nSalário: "+this.salario+
            "\nFaltas: "+this.faltas+
            "\nValor Aula: "+this.valorAula+
            "\nNúmero de aulas: "+this.numerosAulas;
        }
    }
}