public class Gato : Animal {
    public bool EhPeludo { get; private set; }

    public Gato(string nome, int idade, string raca, Dono dono, bool ehPeludo) 
        : base(nome, idade, raca, dono) {
        EhPeludo = ehPeludo;
    }

    public override void EmitirSom() {
        Console.WriteLine($"{Nome} diz: Miau!");
    }
}