<?php 
    class Pessoa {
        private $name;
        private $cpf;
        private $dataNascimento;
        private $endereco;
        private $email;
        private $telefone;

        function __construct($name, $cpf, $dataNascimento, $endereco, $email, $telefone) {
            $this->name = $name;
            $this->cpf = $cpf;
            $this->dataNascimento = $dataNascimento;
            $this->endereco = $endereco;
            $this->email = $email;
            $this->telefone = $telefone;
        }

        public function getName() {
            return $this->name;
          }
        
          public function setName($name) {
            $this->name = $name;
          }
        
          public function getCpf() {
            return $this->cpf;
          }
        
          public function setCpf($cpf) {
            $this->cpf = $cpf;
          }
        
          public function getDataNascimento() {
            return $this->dataNascimento;
          }
        
          public function setDataNascimento($dataNascimento) {
            $this->dataNascimento = $dataNascimento;
          }
        
          public function getEndereco() {
            return $this->endereco;
          }
        
          public function setEndereco($endereco) {
            $this->endereco = $endereco;
          }
        
          public function getEmail() {
            return $this->email;
          }
        
          public function setEmail($email) {
            $this->email = $email;
          }
        
          public function getTelefone() {
            return $this->telefone;
          }
        
          public function setTelefone($telefone) {
            $this->telefone = $telefone;
          }
       
        public function showCliente(){
            echo "<div class='product'>";
            echo "Name: ".$this->name . "<br/>";
            echo "Cpf: ".$this->cpf . "<br/>";
            echo "dataNascimento: ".$this->dataNascimento . "<br/>";
            echo "endereco: ".$this->endereco . "<br/>";
            echo "email: ".$this->email . "<br/>";
            echo "telefone: ".$this->telefone . "<br/>";
            echo "</div>";
        }
    }

?>