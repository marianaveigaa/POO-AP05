public class Dono {
    public string Nome { get; private set; }
    public string Telefone { get; private set; }
    public List<Animal> Pets { get; private set; } = new List<Animal>();

    public Dono(string nome, string telefone) {
        Nome = nome;
        Telefone = telefone;
    }

    public void AdicionarPet(Animal pet) {
        Pets.Add(pet);
    }
}