public class Candidato
{
    public int Id { get; private set; }
    public string Nome { get; private set; }
    public string Email { get; private set; }
    public string Curriculo { get; private set; }
    public List<Candidatura> Candidaturas { get; private set; } = new List<Candidatura>();

    public Candidato(int id, string nome, string email, string curriculo)
    {
        Id = id;
        Nome = nome;
        Email = email;
        Curriculo = curriculo;
    }

    public void AdicionarCandidatura(Candidatura candidatura)
    {
        Candidaturas.Add(candidatura);
    }
}