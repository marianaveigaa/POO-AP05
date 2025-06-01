public class Filme : Midia
{
    public string Diretor { get; private set; }
    public int Ano { get; private set; }
    public List<string> Elenco { get; private set; }

    public Filme(string titulo, TimeSpan duracao, string genero, 
                string diretor, int ano, List<string> elenco)
        : base(titulo, duracao, genero)
    {
        Diretor = diretor;
        Ano = ano;
        Elenco = elenco;
    }

    public override void ExibirResumo()
    {
        Console.WriteLine($"FILME: {Titulo} ({Ano})");
        Console.WriteLine($"Diretor: {Diretor}");
        Console.WriteLine($"Duração: {Duracao:hh\\:mm}");
        Console.WriteLine($"Gênero: {Genero}");
        Console.WriteLine($"Disponível: {(Disponivel ? "Sim" : "Não")}");
        Console.WriteLine("Elenco principal:");
        foreach (var ator in Elenco.Take(3))
        {
            Console.WriteLine($"- {ator}");
        }
    }
}