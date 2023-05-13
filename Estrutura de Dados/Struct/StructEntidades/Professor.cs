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
        private int cargaHoraria;
        
        private int numeroAulas;
        private float salario;
        private int faltas;

        public void reajusteSalarialEmValor(float valor){
            this.salario += valor;
        }
        public void reajusteSalarialEmPorcentagem(int porcentagem){
            float aumento = this.salario + (this.salario*porcentagem/100);
            this.salario = aumento;
        }
        public void descontoSalarialPorFaltaEmValor(){
            
        }
        public void descontoSalarialPorFaltaEmPorcentagem(){

        }
        public void aumentarCargaHorariaDeTrabalho(int horas){
            this.cargaHoraria += horas;
        }
        public string imprimir(){
            return "\nNome do produto: "+this.nome+
            "\nId: "+this.id+
            "\nCarga Horária: "+this.cargaHoraria+
            "\nSalário: "+this.salario+
            "\nFaltas: "+this.faltas;
        }
    }
}