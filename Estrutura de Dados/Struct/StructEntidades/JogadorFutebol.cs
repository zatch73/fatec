using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Struct
{
    public struct JogadorFutebol
    {
        private string nome;
        private int idade;
        private float peso;
        private float altura;
        private string clube;
        private int cartaoAmarelo;
        private int cartaoVermelho;
        public JogadorFutebol(string nome, int idade, float peso, float altura, string clube){
            this.nome = nome;
            this.idade = idade;
            this.peso = peso;
            this.altura = altura;
            this.clube = clube;
        }

        public void registrarNumeroCatoesAmarelos(int cartao){
            this.cartaoAmarelo += cartao;
        }

        public void registrarNumeroCatoesVermelhos(int cartao){
            this.cartaoVermelho += cartao;
        }

        public string verificarVinculoClube(){
            return "O clube com vínculo: "+this.clube;
        }

        public string imprimir(){
            return "\nNome do jogador: "+this.nome+
            "\nIdade: "+this.idade+
            "\nPeso: "+this.peso+
            "\nAltura: "+this.altura+
            "\nClube: "+this.clube+
            "\nCartão Amarelo: "+this.cartaoAmarelo+
            "\nCartão Vermelho: "+this.cartaoVermelho;
        }
    }
}