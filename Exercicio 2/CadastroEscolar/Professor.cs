public class Professor : Pessoa {
    public List<string> Disciplinas { get; private set; }

    public Professor(string nome, string cpf, DateTime dataNascimento, List<string> disciplinas) 
        : base(nome, cpf, dataNascimento) {
        Disciplinas = disciplinas;
    }

    public override void ExibirInformacoes() {
        base.ExibirInformacoes();
        Console.WriteLine($"Disciplinas: {string.Join(", ", Disciplinas)} (Professor)");
    }
}