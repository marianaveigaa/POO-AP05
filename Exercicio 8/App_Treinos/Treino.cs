public class Treino
{
    public DateTime DataCriacao { get; }
    public string Tipo { get; set; } 
    public string Objetivo { get; set; } 
    public List<Exercicio> Exercicios { get; } = new List<Exercicio>();

    public Treino(string tipo, string objetivo)
    {
        DataCriacao = DateTime.Now;
        Tipo = tipo;
        Objetivo = objetivo;
    }

    public void AdicionarExercicio(Exercicio exercicio)
    {
        Exercicios.Add(exercicio);
    }

    public void RemoverExercicio(Exercicio exercicio)
    {
        Exercicios.Remove(exercicio);
    }

    public double CalcularCargaTotal()
    {
        return Exercicios.Sum(e => e.Series * e.Repeticoes * e.Carga);
    }
}