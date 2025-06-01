using System;
using System.Collections.Generic;
public class ItemPedido {
    public Produto Produto { get; private set; }
    public int Quantidade { get; private set; }
    public decimal Subtotal => Produto.Preco * Quantidade; // Calculado automaticamente

    public ItemPedido(Produto produto, int quantidade) {
        Produto = produto;
        Quantidade = quantidade;
    }
}