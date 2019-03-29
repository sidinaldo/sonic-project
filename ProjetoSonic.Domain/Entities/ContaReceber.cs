using System;


namespace ProjetoSonic.Domain.Entities
{
    public class ContaReceber
    {

        public int ContaReceberId { get; set; }
        public decimal Valor { get; set; }
        public bool Status { get; set; }
        public DateTime Vencimento { get; set; }
        public string Observacao { get; set; }
        public DateTime DataCadastro { get; set; }
        public int IdSessao { get; set; }     
    }
}
