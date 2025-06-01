public class Aluno
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Objetivo { get; set; } 
    public Dictionary<string, double> MedidasCorporais { get; set; } 
    public List<Treino> Treinos { get; set; } = new List<Treino>();

    public Aluno(string nome, int idade, string objetivo)
    {
        Nome = nome;
        Idade = idade;
        Objetivo = objetivo;
        MedidasCorporais = new Dictionary<string, double>();
    }

    public void AdicionarTreino(Treino treino)
    {
        Treinos.Add(treino);
    }

    public void AdicionarMedida(string tipo, double valor)
    {
        MedidasCorporais[tipo] = valor;
    }
}