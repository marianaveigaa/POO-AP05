class Program {
    static void Main() {
        var livro1 = new Livro("Dom Quixote", "Miguel de Cervantes");
        var leitor1 = new Leitor("Maria");

        try {
            var emprestimo1 = new Emprestimo(livro1, leitor1);
            Console.WriteLine($"Empréstimo realizado: {livro1.Titulo} para {leitor1.Nome}");

            
            var emprestimo2 = new Emprestimo(livro1, leitor1); 
        } catch (Exception ex) {
            Console.WriteLine($"Erro: {ex.Message}");
        }

        emprestimo1.Devolver();
        Console.WriteLine($"Livro devolvido. Disponível: {livro1.Disponivel}");
    }
}