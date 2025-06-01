public class Serie : Midia
{
    public int Temporadas { get; private set; }
    public int NumeroEpisodios { get; private set; }
    public List<Episodio> Episodios { get; private set; } = new List<Episodio>();

    public Serie(string titulo, TimeSpan duracaoMedia, string genero, 
                int temporadas, int numeroEpisodios)
        : base(titulo, duracaoMedia, genero)
    {
        Temporadas = temporadas;
        NumeroEpisodios = numeroEpisodios;
    }

    public void AdicionarEpisodio(Episodio episodio)
    {
        Episodios.Add(episodio);
    }

    public override void ExibirResumo()
    {
        Console.WriteLine($"SÉRIE: {Titulo}");
        Console.WriteLine($"Temporadas: {Temporadas}");
        Console.WriteLine($"Episódios: {NumeroEpisodios}");
        Console.WriteLine($"Duração média: {Duracao:hh\\:mm} por episódio");
        Console.WriteLine($"Gênero: {Genero}");
        Console.WriteLine($"Disponível: {(Disponivel ? "Sim" : "Não")}");
        
        if (Episodios.Any())
        {
            Console.WriteLine("\nÚltimos episódios adicionados:");
            foreach (var ep in Episodios.TakeLast(3).OrderBy(e => e.Numero))
            {
                Console.WriteLine($"- S{ep.Temporada:00}E{ep.Numero:00}: {ep.Titulo} ({ep.Duracao:hh\\:mm})");
            }
        }
    }
}

public class Episodio
{
    public int Temporada { get; private set; }
    public int Numero { get; private set; }
    public string Titulo { get; private set; }
    public TimeSpan Duracao { get; private set; }
    public string Sinopse { get; private set; }

    public Episodio(int temporada, int numero, string titulo, TimeSpan duracao, string sinopse)
    {
        Temporada = temporada;
        Numero = numero;
        Titulo = titulo;
        Duracao = duracao;
        Sinopse = sinopse;
    }
}