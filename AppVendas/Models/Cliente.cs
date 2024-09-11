namespace AppVendas.Models
{
    public class Cliente
    {
        public Guid ClienteId { get; set; }
        public string NomeCliente { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string CadastroAtivo { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
