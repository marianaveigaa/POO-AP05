class Program
{
    static void Main()
    {
        // Criando vagas
        var vaga1 = new Vaga(1, "Desenvolvedor C#", "Tech Solutions", "Vaga para desenvolvedor pleno");
        var vaga2 = new Vaga(2, "Analista de Dados", "Data Corp", "Vaga para analista júnior");

        // Criando candidatos
        var candidato1 = new Candidato(1, "João Silva", "joao@email.com", "5 anos de experiência em .NET");
        var candidato2 = new Candidato(2, "Maria Souza", "maria@email.com", "Formação em Ciência de Dados");

        // Registrando candidaturas
        var candidatura1 = new Candidatura(candidato1, vaga1, DateTime.Now);
        var candidatura2 = new Candidatura(candidato2, vaga1, DateTime.Now.AddDays(-1));
        var candidatura3 = new Candidatura(candidato2, vaga2, DateTime.Now);

        // Atualizando status
        candidatura1.AtualizarStatus(StatusCandidatura.EmAnalise);
        candidatura3.AtualizarStatus(StatusCandidatura.Aprovada);

        // Consultas
        Console.WriteLine($"Candidatos para a vaga '{vaga1.Titulo}':");
        foreach (var c in vaga1.Candidaturas)
        {
            Console.WriteLine($"- {c.Candidato.Nome} (Status: {c.Status})");
        }

        Console.WriteLine($"\nVagas aplicadas por '{candidato2.Nome}':");
        foreach (var c in candidato2.Candidaturas)
        {
            Console.WriteLine($"- {c.Vaga.Titulo} em {c.Vaga.Empresa} (Status: {c.Status})");
        }
    }
}