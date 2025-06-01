using System;
using System.Collections.Generic;
public class Curso {
    public string Nome { get; private set; }
    public string Descricao { get; private set; }
    public string Nivel { get; private set; }
    public List<Aula> Aulas { get; private set; } = new List<Aula>();

    public Curso(string nome, string descricao, string nivel) {
        Nome = nome;
        Descricao = descricao;
        Nivel = nivel;
    }

    public void AdicionarAula(Aula aula) {
        Aulas.Add(aula);
    }

    public void RemoverCurso() {
        // Simula a exclusão em cascata (composição)
        Aulas.Clear(); // Aulas são removidas junto com o curso
    }
}
