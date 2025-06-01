class Program
{
    static void Main()
    {
        // Criando eventos
        var oficina = new Oficina("Pintura em Aquarela", 
                                new DateTime(2023, 11, 15), 
                                new TimeSpan(14, 0, 0),
                                "Sala 3", 15, "Pincéis, tinta aquarela e papel", 20);

        var palestra = new Palestra("Inteligência Artificial no Cotidiano",
                                  new DateTime(2023, 11, 20),
                                  new TimeSpan(19, 30, 0),
                                  "Auditório Principal", 100,
                                  "Dra. Ana Beatriz", 
                                  "Aplicações práticas de IA", 
                                  new TimeSpan(1, 30, 0));

        var show = new Show("Festival de Jazz",
                          new DateTime(2023, 12, 5),
                          new TimeSpan(21, 0, 0),
                          "Palco Externo", 500,
                          "Jazz Trio & Convidados",
                          "Jazz Contemporâneo",
                          "Livre");

        // Criando participantes
        var participante1 = new Participante("Carlos Silva", "carlos@email.com");
        var participante2 = new Participante("Mariana Oliveira", "mariana@email.com");

        // Inscrições
        oficina.AdicionarParticipante(participante1);
        palestra.AdicionarParticipante(participante1);
        palestra.AdicionarParticipante(participante2);
        show.AdicionarParticipante(participante2);

        // Exibindo informações
        Console.WriteLine("=== DETALHES DOS EVENTOS ===");
        oficina.ExibirInformacoes();
        Console.WriteLine();
        palestra.ExibirInformacoes();
        Console.WriteLine();
        show.ExibirInformacoes();

        // Listando eventos por participante
        participante1.ListarEventos();
        participante2.ListarEventos();
    }
}