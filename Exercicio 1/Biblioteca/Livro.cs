using System;
using System.Collections.Generic;

// Classe Livro
public class Livro {
    public string Titulo { get; private set; }
    public string Autor { get; private set; }
    public bool Disponivel { get; private set; }

    public Livro(string titulo, string autor) {
        Titulo = titulo;
        Autor = autor;
        Disponivel = true; // Inicia como disponível
    }

    public void Emprestar() {
        if (Disponivel) {
            Disponivel = false;
        } else {
            throw new InvalidOperationException("Livro já emprestado!");
        }
    }

    public void Devolver() {
        Disponivel = true;
    }
}
