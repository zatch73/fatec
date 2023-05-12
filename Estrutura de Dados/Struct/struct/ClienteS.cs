namespace Struct
{
    public struct ClientS{
        private string nome;
        private string cpf;
        private string dataNascimento;
        private string email;

        public ClientS(string nome, string cpf, string dataNascimento, string email){
            this.nome = nome;
            this.cpf = cpf;
            this.dataNascimento = dataNascimento;
            this.email = email;
        }

        public string show(){
            return "\nNome: " + this.nome + "\nCpf: " + this.cpf + "\nDataNascismento: " + this.dataNascimento + "\nEmail: " + this.email;
        }
    }
}