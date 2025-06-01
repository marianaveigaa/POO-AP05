public abstract class Midia
{
    public string Titulo { get; protected set; }
    public TimeSpan Duracao { get; protected set; }
    public string Genero { get; protected set; }
    public bool Disponivel { get; protected set; } = true;

    protected Midia(string titulo, TimeSpan duracao, string genero)
    {
        Titulo = titulo;
        Duracao = duracao;
        Genero = genero;
    }

    public abstract void ExibirResumo();
    
    public void AlterarDisponibilidade(bool disponivel)
    {
        Disponivel = disponivel;
    }
}