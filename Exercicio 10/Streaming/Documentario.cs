public class Documentario : Midia
{
    public string Tema { get; private set; }
    public string Narrador { get; private set; }
    public bool BaseadoEmFatocos { get; private set; }

    public Documentario(string titulo, TimeSpan duracao, string genero, 
                      string tema, string narrador, bool baseadoEmFatocos)
        : base(titulo, duracao, genero)
    {
        Tema = tema;
        Narrador = narrador;
        BaseadoEmFatocos = baseadoEmFatocos;
    }

    public override void ExibirResumo()
    {
        Console.WriteLine($"DOCUMENTÁRIO: {Titulo}");
        Console.WriteLine($"Tema: {Tema}");
        Console.WriteLine($"Narrador: {Narrador}");
        Console.WriteLine($"Baseado em fatos: {(BaseadoEmFatocos ? "Sim" : "Não")}");
        Console.WriteLine($"Duração: {Duracao:hh\\:mm}");
        Console.WriteLine($"Gênero: {Genero}");
        Console.WriteLine($"Disponível: {(Disponivel ? "Sim" : "Não")}");
    }
}