namespace AppVendas.Models
{
    public class Venda
    {
        public Guid VendaId { get; set; }
        public int NotaFiscal { get; set; }
        public DateTime DataVenda { get; set; }
        public string TotakVenda { get; set; }

        /*ref model client*/
        public Guid ClienteId { get; set; }
        public Cliente? Cliente { get; set; }
    }
}
