namespace agregracaoVenda{
    class Program{
        static void Main(string[] args)
        {
            List<Produto> prods = new List<Produto>();
            prods.Add(new Produto("Teclado", 100.0));
            prods.Add(new Produto("Mouse", 35.0));
            prods.Add(new Produto("Cadeira", 65.0));

            Venda venda1 = new Venda(new Comprador("Lucas", 1000), new Vendedor("Joao"), prods);

            venda1.MostrarAtributos();


        }
    }
}
