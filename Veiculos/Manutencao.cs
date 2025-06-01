public class Manutencao
{
    public DateTime Data { get; private set; }
    public string Descricao { get; private set; }
    public string Tipo { get; private set; } // Preventiva, Corretiva
    public Veiculo Veiculo { get; private set; }

    public Manutencao(DateTime data, string descricao, string tipo, Veiculo veiculo)
    {
        if (veiculo.Manutencoes.Any(m => m.Data.Date == data.Date))
        {
            throw new InvalidOperationException($"Já existe manutenção para este veículo na data {data:dd/MM/yyyy}");
        }
        Data = data;
        Descricao = descricao;
        Tipo = tipo;
        Veiculo = veiculo;
    }
}