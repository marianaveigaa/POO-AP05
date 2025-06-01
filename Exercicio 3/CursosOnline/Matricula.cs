using System;
using System.Collections.Generic;
public class Matricula {
    public Aluno Aluno { get; private set; }
    public Curso Curso { get; private set; }
    public DateTime DataInscricao { get; private set; }
    public int Progresso { get; private set; } // 0 a 100

    public Matricula(Aluno aluno, Curso curso, DateTime dataInscricao) {
        Aluno = aluno;
        Curso = curso;
        DataInscricao = dataInscricao;
        Progresso = 0;
    }

    public void AtualizarProgresso(int progresso) {
        if (progresso >= 0 && progresso <= 100) {
            Progresso = progresso;
        }
    }
}