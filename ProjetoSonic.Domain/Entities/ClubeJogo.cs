using System;

namespace ProjetoSonic.Domain.Entities
{
    public class ClubeJogo
    {
        public int ClubeJogoId { get; set; }
        public int JogoId { get; set; }
        public int ClubeId { get; set; }
        public virtual Clube Clube { get; set; }
        public virtual Jogo Jogo { get; set; }
        public DateTime DataCadastro { get; set; }

    }
}
