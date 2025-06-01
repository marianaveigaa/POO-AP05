public class Show : Evento
{
    public string Artista { get; private set; }
    public string EstiloMusical { get; private set; }
    public string ClassificacaoEtaria { get; private set; }

    public Show(string titulo, DateTime data, TimeSpan horario, string local, 
               int capacidade, string artista, string estilo, string classificacao)
        : base(titulo, data, horario, local, capacidade)
    {
        Artista = artista;
        EstiloMusical = estilo;
        ClassificacaoEtaria = classificacao;
    }

    public override void ExibirInformacoes()
    {
        Console.WriteLine($"SHOW: {Titulo}");
        Console.WriteLine($"Artista: {Artista} ({EstiloMusical})");
        Console.WriteLine($"Classificação etária: {ClassificacaoEtaria}");
        Console.WriteLine($"Data: {Data:dd/MM/yyyy} às {Horario:hh\\:mm}");
        Console.WriteLine($"Local: {Local}");
        Console.WriteLine($"Ingressos disponíveis: {Capacidade - Participantes.Count}/{Capacidade}");
    }
}