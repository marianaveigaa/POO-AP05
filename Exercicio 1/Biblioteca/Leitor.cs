using System;
using System.Collections.Generic;

    public Leitor(string nome) {
        Nome = nome;
        Emprestimos = new List<Emprestimo>();
    }

    public void AdicionarEmprestimo(Emprestimo emprestimo) {
        Emprestimos.Add(emprestimo);
    }
}
