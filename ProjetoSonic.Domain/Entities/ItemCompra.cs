using System;
using System.Globalization;

namespace ProjetoSonic.Domain.Entities
{
    public class ItemCompra
    {
        public int ItemCompraId { get; set; }
        public int QuantidadeItemCompra { get; set; }
        public decimal ValorItemCompra { get; set; }
        public int CompraId { get; set; }
        public int ProdutoId { get; set; }
        public DateTime Datacadastro { get; set; }
        public int IdSessao { get; set; }
        
        
         public string ItemVendaValorString
    {
        get
        {
            return "R$ " + String.Format(CultureInfo.InvariantCulture, "{0:0.00}", this.ValorItemCompra);
        }
    } 
    }

   
}
