using System;
using System.Collections.Generic;
public class Pedido {
    public DateTime DataPedido { get; private set; }
    public List<ItemPedido> Itens { get; private set; } = new List<ItemPedido>();
    public decimal Total { get; private set; }

    public Pedido() {
        DataPedido = DateTime.Now;
    }

    public void AdicionarItem(Produto produto, int quantidade) {
        var item = new ItemPedido(produto, quantidade);
        Itens.Add(item);
        CalcularTotal();
    }

    public void RemoverItem(ItemPedido item) {
        Itens.Remove(item);
        CalcularTotal();
    }

    private void CalcularTotal() {
        Total = 0;
        foreach (var item in Itens) {
            Total += item.Subtotal;
        }
    }
}