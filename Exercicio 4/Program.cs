class Program {
    static void Main() {
        // Criando donos
        var dono1 = new Dono("Carlos", "11 9999-8888");
        var dono2 = new Dono("Ana", "11 7777-5555");

        // Criando pets (polimorfismo: tratados como Animal)
        Animal cachorro = new Cachorro("Rex", 3, "Labrador", dono1, "Grande");
        Animal gato = new Gato("Mimi", 2, "Siamês", dono2, true);

        // Associando pets aos donos
        dono1.AdicionarPet(cachorro);
        dono2.AdicionarPet(gato);

        // Chamando métodos polimórficos
        cachorro.EmitirSom(); // Rex diz: Au Au!
        gato.EmitirSom();    // Mimi diz: Miau!

        // Agendando serviços (com validação)
        ServicoPetShop.AgendarBanhoETosa(cachorro); // Sucesso (Cachorro)
        ServicoPetShop.AgendarBanhoETosa(gato);     // ERRO (Gato não pode)
    }
}