class Program
{
    static void Main()
    {
        // Criando veículos
        var veiculo1 = new Veiculo("Fiat Uno", "ABC-1234", "Passeio");
        var veiculo2 = new Veiculo("Volkswagen Saveiro", "XYZ-5678", "Utilitário");

        // Adicionando manutenções (sucesso)
        var manutencao1 = new Manutencao(new DateTime(2023, 10, 1), "Troca de óleo", "Preventiva", veiculo1);
        var manutencao2 = new Manutencao(new DateTime(2023, 10, 5), "Revisão geral", "Preventiva", veiculo1);

        // Tentando adicionar manutenção na mesma data (erro)
        try
        {
            var manutencao3 = new Manutencao(new DateTime(2023, 10, 1), "Reparo no motor", "Corretiva", veiculo1);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }

        // Exibindo histórico
        Console.WriteLine($"Manutenções do veículo {veiculo1.Placa}:");
        foreach (var m in veiculo1.Manutencoes)
        {
            Console.WriteLine($"{m.Data:dd/MM/yyyy} - {m.Tipo}: {m.Descricao}");
        }
    }
}