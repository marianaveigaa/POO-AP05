using System;
using System.Collections.Generic;
public class Aluno {
    public string Nome { get; private set; }
    public string Email { get; private set; }
    public List<Matricula> Matriculas { get; private set; } = new List<Matricula>();

    public Aluno(string nome, string email) {
        Nome = nome;
        Email = email;
    }

    public void Matricular(Curso curso, DateTime dataInscricao) {
        var matricula = new Matricula(this, curso, dataInscricao);
        Matriculas.Add(matricula);
    }
}
