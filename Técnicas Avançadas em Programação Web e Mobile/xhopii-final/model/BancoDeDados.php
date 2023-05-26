<?php 
class BancoDeDados {
    private $host;
    private $login;
    private $password;
    private $dataBase;

    public function __construct($host, $login, $password, $dataBase) {
        $this->host = $host;
        $this->login = $login;
        $this->password = $password;
        $this->dataBase = $dataBase;
    }

    public function conectarBD() {
        $conexao = mysqli_connect($this->host, $this->login, $this->password, $this->dataBase);
        return $conexao;
    }

    public function inserirFuncionario($funcionario) {
        $conexao = $this->conectarBD();
        $consulta = "INSERT INTO funcionario (cpf, nome, sobrenome, dataNascimento, telefone, email, salario) 
                     VALUES ('$funcionario->getCpf','$funcionario->getNome','$funcionario->getSobrenome','$funcionario->getDataNasc','$funcionario->getTelefone','$funcionario->getEmail','$funcionario->getSalario')";
        mysqli_query($conexao, $consulta);
    }

    public function inserirProduto($produto) {
        $conexao = $this->conectarBD();
        $consulta = "INSERT INTO produto (nome, fabricante, descricao, valor) 
                     VALUES ('$produto->getNome()','$produto->getFabricante()','$produto->getDescricao()','$produto->getValor()')";
        mysqli_query($conexao, $consulta);
    }

    public function inserirCliente($cliente) {
        $conexao = $this->conectarBD();
        $consulta = "INSERT INTO cliente (cpf, nome, sobrenome, dataNascimento, telefone, email, senha) 
                     VALUES ('$cliente->getCpf','$cliente->getNome','$cliente->getSobrenome','$cliente->getDataNasc','$cliente->getTelefone','$cliente->getEmail', '$cliente->getSenha')";
        mysqli_query($conexao, $consulta);
    }

    public function retornarClientes() {
        $conexao = $this->conectarBD();
        $consulta = "SELECT * FROM cliente";
        $listaClientes = mysqli_query($conexao, $consulta);
        return $listaClientes;
    }

    public function retornarProdutos() {
        $conexao = $this->conectarBD();
        $consulta = "SELECT * FROM produto";
        $listaProdutos = mysqli_query($conexao, $consulta);
        return $listaProdutos;
    }
}
?>