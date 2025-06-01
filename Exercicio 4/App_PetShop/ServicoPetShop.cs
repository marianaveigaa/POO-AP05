public class ServicoPetShop {
    public static void AgendarBanhoETosa(Animal animal) {
        if (animal.PodeReceberBanhoETosa()) {
            Console.WriteLine($"Banho e tosa agendado para {animal.Nome} (Dono: {animal.Dono.Nome})");
        } else {
            Console.WriteLine($"ERRO: {animal.Nome} não pode receber banho e tosa!");
        }
    }
}