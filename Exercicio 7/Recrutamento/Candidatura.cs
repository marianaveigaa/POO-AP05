public enum StatusCandidatura { Enviada, EmAnalise, Aprovada, Rejeitada }

public class Candidatura
{
    public Candidato Candidato { get; private set; }
    public Vaga Vaga { get; private set; }
    public DateTime DataEnvio { get; private set; }
    public StatusCandidatura Status { get; private set; }

    public Candidatura(Candidato candidato, Vaga vaga, DateTime dataEnvio)
    {
        Candidato = candidato;
        Vaga = vaga;
        DataEnvio = dataEnvio;
        Status = StatusCandidatura.Enviada;

        candidato.AdicionarCandidatura(this);
        vaga.AdicionarCandidatura(this);
    }

    public void AtualizarStatus(StatusCandidatura novoStatus)
    {
        Status = novoStatus;
    }
}