public class Participante
{
    public string Nome { get; private set; }
    public string Email { get; private set; }
    public List<Evento> EventosInscritos { get; private set; } = new List<Evento>();

    public Participante(string nome, string email)
    {
        Nome = nome;
        Email = email;
    }

    public void AdicionarEvento(Evento evento)
    {
        if (!EventosInscritos.Contains(evento))
        {
            EventosInscritos.Add(evento);
        }
    }

    public void ListarEventos()
    {
        Console.WriteLine($"\nEventos de {Nome}:");
        foreach (var evento in EventosInscritos)
        {
            evento.ExibirInformacoes();
            Console.WriteLine();
        }
    }
}