namespace AppVendas.Models
{
    public class ItemDaVenda
    {
        public Guid ItemDaVendaId { get; set; }

        public Guid VendaId { get; set; }
        public Venda? Venda { get; set; }

        public Guid ProdutoId { get; set; }
        public Produto? Produto { get; set; }

        public double QtdVendida { get; set; }
        public double ValorTotalDoItem { get; set; }
    }
}
