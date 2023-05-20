<?php 
    class Produto{
        private $nome; 
        private $fabricante; 
        private $descricao; 
        private $valor;

        public function __construct($nome, $fabricante, $descricao, $valor){
            $this->nome = $nome;
            $this->fabricante = $fabricante;
            $this->descricao = $descricao;
            $this->valor = $valor;
        }

        public function getNome() {
            return $this->nome;
        }
    
        public function setNome($nome) {
            $this->nome = $nome;
        }
    
        public function getFabricante() {
            return $this->fabricante;
        }
    
        public function setFabricante($fabricante) {
            $this->fabricante = $fabricante;
        }
    
        public function getDescricao() {
            return $this->descricao;
        }
    
        public function setDescricao($descricao) {
            $this->descricao = $descricao;
        }
    
        public function getValor() {
            return $this->valor;
        }
    
        public function setValor($valor) {
            $this->valor = $valor;
        }

        public function aplicarCupom($cumpom){
            $cumpom /= 100;
            $this->valor = $this->valor - ($this->valor*$cumpom);
        }
    }
?>