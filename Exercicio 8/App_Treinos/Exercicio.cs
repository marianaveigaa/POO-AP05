public class Exercicio
{
    public string Nome { get; set; }
    public int Series { get; set; }
    public int Repeticoes { get; set; }
    public double Carga { get; set; } 
    public string Observacoes { get; set; }

    public Exercicio(string nome, int series, int repeticoes, double carga)
    {
        Nome = nome;
        Series = series;
        Repeticoes = repeticoes;
        Carga = carga;
    }

    public void AtualizarParametros(int series, int repeticoes, double carga)
    {
        Series = series;
        Repeticoes = repeticoes;
        Carga = carga;
    }
}