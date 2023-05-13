using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Struct.StructEntidades
{
    public struct EquipeEsports
    {
        private string nome;
        private int numeroCampeonatosVencidos;
        private float valorTotal;
        private int dataEstreia;
        private string estadoDaEquipe = "";

        public EquipeEsports(string nome, int numeroCampeonatosVencidos, float valorTotal, int dataEstreia){
            this.nome = nome;
            this.numeroCampeonatosVencidos = numeroCampeonatosVencidos;
            this.valorTotal = valorTotal;
            this.dataEstreia = dataEstreia;
            verificarAnoEstreia();
        }
        public void registrarCampeonatoVencido(float valorPremio){
            this.numeroCampeonatosVencidos++;
            atualizarValorTotalPremiacoes(valorPremio);
        }

        public void atualizarValorTotalPremiacoes(float valor){
            this.valorTotal += valor;
        }

        public void verificarAnoEstreia(){
            DateTime start = DateTime.Now;
            int ano = start.Year;

            if(this.dataEstreia == ano){
                this.estadoDaEquipe = "NOVATA";
            }else {
                 this.estadoDaEquipe = "VETERANA";
            }
        }
        
        public string imprimir(){
            return "\nNome do jogador: "+this.nome+
            "\nNumeroCampeonatosVencidos: "+this.numeroCampeonatosVencidos+
            "\nPeso: "+this.valorTotal+
            "\nAltura: "+this.dataEstreia+
            "\nClube: "+this.estadoDaEquipe;
        }
    }
}