<?php

class Controlador{
    private $banco;


    function __construct(){
        require_once "../model/BancoDeDados.php";
        $this->banco = new BancoDeDados("", "","", "");
    }
    
    public function cadastrarProduto($nome, $fabricante, $descricao, $valor){
        require_once("../model/Produto.php");
        $produto = new Produto($nome, $fabricante, $descricao, $valor);
        $this->banco->inserirProduto($produto);
    }
    public function cadastrarFuncionario($nome, $sobrenome, $cpf, $dataNasc, $telefone, $email, $salario){
        require_once("../model/Funcionario.php");
        $cliente = new Funcionario($nome, $sobrenome, $cpf, $dataNasc, $telefone, $email, $salario);
        $this->banco->inserirCliente($cliente);
    }
    public function cadastrarCliente($nome, $sobrenome, $cpf, $dataNasc, $telefone, $email, $senha){
        require_once("../model/Cliente.php");
        $cliente = new Cliente($nome, $sobrenome, $cpf, $dataNasc, $telefone, $email, $senha);
        $this->banco->inserirFuncionario($cliente);
    }

    public function visualizarProdutos($nome, $fabricante, $descricao, $valor){
        $listaProdutos = $this->banco->retornarClientes();
        while($produto = mysqli_fetch_assoc($listaProdutos)){
            echo "<section class=\"conteudo-bloco\">";
            echo "<h2>" . $produto["nome"] . "</h2>";
            echo "<p>Fabricante: " . $produto["fabricante"] . "</p>";
            echo "<p>Descrição: " . $produto["descricao"] . "</p>";
            echo "<p>Valor: " . $produto["valor"] . "</p>";
            echo "</section>";
        }
    }


}

?>