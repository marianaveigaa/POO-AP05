class Program
{
    static void Main()
    {
        // Criando um aluno
        var aluno = new Aluno("João Silva", 28, "Hipertrofia");
        aluno.AdicionarMedida("altura", 1.75);
        aluno.AdicionarMedida("peso", 78.5);

        // Criando um treino
        var treinoSuperior = new Treino("Superior", "Hipertrofia");
        
        // Adicionando exercícios ao treino
        treinoSuperior.AdicionarExercicio(new Exercicio("Supino Reto", 4, 10, 60));
        treinoSuperior.AdicionarExercicio(new Exercicio("Remada Curvada", 4, 10, 50));
        treinoSuperior.AdicionarExercicio(new Exercicio("Desenvolvimento com Halteres", 3, 12, 18));

        // Associando o treino ao aluno
        aluno.AdicionarTreino(treinoSuperior);

        // Calculando a carga total do treino
        double cargaTotal = treinoSuperior.CalcularCargaTotal();
        Console.WriteLine($"Carga total do treino: {cargaTotal} kg");

        // Atualizando um exercício
        var primeiroExercicio = treinoSuperior.Exercicios[0];
        primeiroExercicio.AtualizarParametros(4, 12, 65);

        // Recalculando após atualização
        cargaTotal = treinoSuperior.CalcularCargaTotal();
        Console.WriteLine($"Nova carga total do treino: {cargaTotal} kg");

        // Listando os treinos do aluno
        Console.WriteLine($"\nTreinos de {aluno.Nome}:");
        foreach (var treino in aluno.Treinos)
        {
            Console.WriteLine($"- {treino.Tipo} ({treino.Objetivo}) criado em {treino.DataCriacao:dd/MM/yyyy}");
            Console.WriteLine("  Exercícios:");
            foreach (var exercicio in treino.Exercicios)
            {
                Console.WriteLine($"  * {exercicio.Nome}: {exercicio.Series}x{exercicio.Repeticoes} com {exercicio.Carga}kg");
            }
        }
    }
}