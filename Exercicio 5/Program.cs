class Program {
    static void Main() {
        var produto1 = new Produto(1, "Notebook", 3500.00m);
        var produto2 = new Produto(2, "Mouse", 120.50m);

        var pedido = new Pedido();
        pedido.AdicionarItem(produto1, 1);
        pedido.AdicionarItem(produto2, 2);

        Console.WriteLine($"Pedido em: {pedido.DataPedido:dd/MM/yyyy HH:mm}");
        Console.WriteLine("Itens:");
        foreach (var item in pedido.Itens) {
            Console.WriteLine($"- {item.Produto.Nome} x{item.Quantidade}: R${item.Subtotal}");
        }
        Console.WriteLine($"Total do pedido: R${pedido.Total}");
    }
}