public class Pessoa {
    public string Nome { get; protected set; }
    public string CPF { get; protected set; }
    public DateTime DataNascimento { get; protected set; }

    public Pessoa(string nome, string cpf, DateTime dataNascimento) {
        Nome = nome;
        CPF = cpf;
        DataNascimento = dataNascimento;
    }

    public virtual void ExibirInformacoes() {
        Console.WriteLine($"Nome: {Nome}, CPF: {CPF}, Nascimento: {DataNascimento:dd/MM/yyyy}");
    }
}