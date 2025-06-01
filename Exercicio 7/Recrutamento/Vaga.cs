public class Vaga
{
    public int Id { get; private set; }
    public string Titulo { get; private set; }
    public string Empresa { get; private set; }
    public string Descricao { get; private set; }
    public List<Candidatura> Candidaturas { get; private set; } = new List<Candidatura>();

    public Vaga(int id, string titulo, string empresa, string descricao)
    {
        Id = id;
        Titulo = titulo;
        Empresa = empresa;
        Descricao = descricao;
    }

    public void AdicionarCandidatura(Candidatura candidatura)
    {
        Candidaturas.Add(candidatura);
    }
}