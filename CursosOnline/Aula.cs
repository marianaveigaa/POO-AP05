using System;
using System.Collections.Generic;
public class Aula {
    public string Titulo { get; private set; }
    public int DuracaoMinutos { get; private set; }
    public string ProfessorResponsavel { get; private set; }

    public Aula(string titulo, int duracao, string professor) {
        Titulo = titulo;
        DuracaoMinutos = duracao;
        ProfessorResponsavel = professor;
    }
}
