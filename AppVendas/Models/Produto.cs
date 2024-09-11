namespace AppVendas.Models
{
    public class Produto
    {
        public Guid ProdutoId { get; set; }
        public string NomeProduto { get; set; }
        public double Valor { get; set; }
        public double QtdEstoque { get; set; }
        public bool CadastroAtivo { get; set; }

        /*foregin key*/
        public Guid CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }
    }
}
