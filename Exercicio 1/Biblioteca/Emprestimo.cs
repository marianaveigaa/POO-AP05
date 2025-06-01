using System;
using System.Collections.Generic;

public class Emprestimo {
    public Livro Livro { get; private set; }
    public Leitor Leitor { get; private set; }
    public DateTime DataEmprestimo { get; private set; }
    public DateTime? DataDevolucao { get; private set; } // Nullable (não devolvido ainda)

    public Emprestimo(Livro livro, Leitor leitor) {
        if (!livro.Disponivel) {
            throw new InvalidOperationException("Livro não disponível para empréstimo!");
        }

        Livro = livro;
        Leitor = leitor;
        DataEmprestimo = DateTime.Now;
        DataDevolucao = null; // Ainda não devolvido

        livro.Emprestar(); // Marca livro como indisponível
        leitor.AdicionarEmprestimo(this); // Adiciona à lista do leitor
    }

    public void Devolver() {
        if (DataDevolucao == null) {
            DataDevolucao = DateTime.Now;
            Livro.Devolver(); // Marca livro como disponível novamente
        }
    }
}