using System;
using System.Collections.Generic;

public class Produto {
    public int Codigo { get; private set; }
    public string Nome { get; private set; }
    public decimal Preco { get; private set; }

    public Produto(int codigo, string nome, decimal preco) {
        Codigo = codigo;
        Nome = nome;
        Preco = preco;
    }
}