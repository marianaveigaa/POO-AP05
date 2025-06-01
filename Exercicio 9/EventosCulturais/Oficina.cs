public class Oficina : Evento
{
    public string MaterialNecessario { get; private set; }
    public int NumeroMaximoParticipantes { get; private set; }

    public Oficina(string titulo, DateTime data, TimeSpan horario, string local, 
                  int capacidade, string material, int maxParticipantes)
        : base(titulo, data, horario, local, capacidade)
    {
        MaterialNecessario = material;
        NumeroMaximoParticipantes = maxParticipantes;
    }

    public override void ExibirInformacoes()
    {
        Console.WriteLine($"OFICINA: {Titulo}");
        Console.WriteLine($"Data: {Data:dd/MM/yyyy} às {Horario:hh\\:mm}");
        Console.WriteLine($"Local: {Local}");
        Console.WriteLine($"Material necessário: {MaterialNecessario}");
        Console.WriteLine($"Vagas: {Participantes.Count}/{Capacidade} (máx: {NumeroMaximoParticipantes})");
    }
}