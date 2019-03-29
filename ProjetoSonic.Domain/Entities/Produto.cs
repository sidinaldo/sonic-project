using System;


namespace ProjetoSonic.Domain.Entities
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string DescricaoProduto { get; set; }
        public decimal ValorPago { get; set; }
        public DateTime DataCadastro { get; set; }        

    }
}
