<?php 
    class Funcionario {
        private $nome;
        private $sobrenome;
        private $cpf;
        private $dataNasc;
        private $telefone;
        private $email;
        private $salario;
    
        public function __construct($nome, $sobrenome, $cpf, $dataNasc, $telefone, $email, $salario) {
            $this->nome = $nome;
            $this->sobrenome = $sobrenome;
            $this->cpf = $cpf;
            $this->dataNasc = $dataNasc;
            $this->telefone = $telefone;
            $this->email = $email;
            $this->salario = $salario;
        }
    
        public function getNome() {
            return $this->nome;
        }
    
        public function setNome($nome) {
            $this->nome = $nome;
        }
    
        public function getSobrenome() {
            return $this->sobrenome;
        }
    
        public function setSobrenome($sobrenome) {
            $this->sobrenome = $sobrenome;
        }
    
        public function getCpf() {
            return $this->cpf;
        }
    
        public function setCpf($cpf) {
            $this->cpf = $cpf;
        }
    
        public function getDataNasc() {
            return $this->dataNasc;
        }
    
        public function setDataNasc($dataNasc) {
            $this->dataNasc = $dataNasc;
        }
    
        public function getTelefone() {
            return $this->telefone;
        }
    
        public function setTelefone($telefone) {
            $this->telefone = $telefone;
        }
    
        public function getEmail() {
            return $this->email;
        }
    
        public function setEmail($email) {
            $this->email = $email;
        }
    
        public function getSalario() {
            return $this->salario;
        }
    
        public function setSalario($salario) {
            $this->salario = $salario;
        }
    }
    
    
?>