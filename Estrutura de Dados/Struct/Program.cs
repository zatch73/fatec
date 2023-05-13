using System;
using Struct;

namespace Struct.StructEntidades{
    public class Program{
        public static void Main(string[] args){
            JogadorFutebol paulo = new JogadorFutebol("Paulo", 21, 70.0f, 1.75f, "PGX");
            paulo.registrarNumeroCatoesAmarelos(1);
            paulo.registrarNumeroCatoesVermelhos(2);
            System.Console.WriteLine(paulo.imprimir());


            EquipeEsports lobos = new EquipeEsports("lobos", 0, 0, 2020);
            lobos.registrarCampeonatoVencido(200f);
            System.Console.WriteLine(lobos.imprimir()); 

            Produto teclado = new Produto("teclado", 1, 199.9f, 10);
            teclado.aplicarCupomDescontoValor(9.9f);
            teclado.aplicarCupomDescontoPorcentagem(50);
            System.Console.WriteLine(teclado.imprimir()); 
        }
    }

    
}