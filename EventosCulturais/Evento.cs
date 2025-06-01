public abstract class Evento
{
    public string Titulo { get; protected set; }
    public DateTime Data { get; protected set; }
    public TimeSpan Horario { get; protected set; }
    public string Local { get; protected set; }
    public int Capacidade { get; protected set; }
    public List<Participante> Participantes { get; protected set; } = new List<Participante>();

    protected Evento(string titulo, DateTime data, TimeSpan horario, string local, int capacidade)
    {
        Titulo = titulo;
        Data = data;
        Horario = horario;
        Local = local;
        Capacidade = capacidade;
    }

    public bool AdicionarParticipante(Participante participante)
    {
        if (Participantes.Count >= Capacidade)
        {
            Console.WriteLine("Evento lotado!");
            return false;
        }
        
        Participantes.Add(participante);
        participante.AdicionarEvento(this);
        return true;
    }

    public abstract void ExibirInformacoes();
}