public class Palestra : Evento
{
    public string Palestrante { get; private set; }
    public string Topico { get; private set; }
    public TimeSpan Duracao { get; private set; }

    public Palestra(string titulo, DateTime data, TimeSpan horario, string local, 
                   int capacidade, string palestrante, string topico, TimeSpan duracao)
        : base(titulo, data, horario, local, capacidade)
    {
        Palestrante = palestrante;
        Topico = topico;
        Duracao = duracao;
    }

    public override void ExibirInformacoes()
    {
        Console.WriteLine($"PALESTRA: {Titulo}");
        Console.WriteLine($"Palestrante: {Palestrante}");
        Console.WriteLine($"Tópico: {Topico}");
        Console.WriteLine($"Data: {Data:dd/MM/yyyy} das {Horario:hh\\:mm} às {(Horario + Duracao):hh\\:mm}");
        Console.WriteLine($"Local: {Local}");
        Console.WriteLine($"Vagas: {Participantes.Count}/{Capacidade}");
    }
}