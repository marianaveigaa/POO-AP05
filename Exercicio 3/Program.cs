class Program {
    static void Main() {
        List<Pessoa> pessoas = new List<Pessoa> {
            new Aluno("João Silva", "123.456.789-00", new DateTime(2005, 3, 15), "A1001", "3ºA"),
            new Professor("Maria Souza", "987.654.321-00", new DateTime(1980, 7, 20), 
                new List<string> { "Matemática", "Física" }),
            new Funcionario("Carlos Oliveira", "456.789.123-00", new DateTime(1975, 11, 5), "Administrativo")
        };

        foreach (var pessoa in pessoas) {
            pessoa.ExibirInformacoes();
            Console.WriteLine("---");
        }
    }
}