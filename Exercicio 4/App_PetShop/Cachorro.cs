public class Cachorro : Animal {
    public string Porte { get; private set; } // Ex: Pequeno, Médio, Grande

    public Cachorro(string nome, int idade, string raca, Dono dono, string porte) 
        : base(nome, idade, raca, dono) {
        Porte = porte;
    }

    public override void EmitirSom() {
        Console.WriteLine($"{Nome} diz: Au Au!");
    }

    public override bool PodeReceberBanhoETosa() {
        return true; // Cachorros podem receber banho e tosa
    }
}