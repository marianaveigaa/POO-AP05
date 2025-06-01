public class Veiculo
{
    public string Modelo { get; private set; }
    public string Placa { get; private set; }
    public string Tipo { get; private set; } // Passeio, Utilitário, etc
    public List<Manutencao> Manutencoes { get; private set; } = new List<Manutencao>();

    public Veiculo(string modelo, string placa, string tipo)
    {
        Modelo = modelo;
        Placa = placa;
        Tipo = tipo;
    }

    public void AdicionarManutencao(Manutencao manutencao)
    {
        
        if (Manutencoes.Any(m => m.Data.Date == manutencao.Data.Date))
        {
            throw new InvalidOperationException($"Já existe uma manutenção para o veículo {Placa} na data {manutencao.Data:dd/MM/yyyy}");
        }

        Manutencoes.Add(manutencao);
    }
}