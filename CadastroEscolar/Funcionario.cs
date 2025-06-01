public class Funcionario : Pessoa {
    public string Setor { get; private set; }

    public Funcionario(string nome, string cpf, DateTime dataNascimento, string setor) 
        : base(nome, cpf, dataNascimento) {
        Setor = setor;
    }

    public override void ExibirInformacoes() {
        base.ExibirInformacoes();
        Console.WriteLine($"Setor: {Setor} (Funcionário)");
    }
}