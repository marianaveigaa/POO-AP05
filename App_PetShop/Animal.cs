public abstract class Animal {
    public string Nome { get; protected set; }
    public int Idade { get; protected set; }
    public string Raca { get; protected set; }
    public Dono Dono { get; protected set; }

    protected Animal(string nome, int idade, string raca, Dono dono) {
        Nome = nome;
        Idade = idade;
        Raca = raca;
        Dono = dono;
    }

    public abstract void EmitirSom();

    public virtual bool PodeReceberBanhoETosa() {
        return false; 
    }
}