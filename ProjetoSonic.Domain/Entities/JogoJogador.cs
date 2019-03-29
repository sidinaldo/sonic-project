namespace ProjetoSonic.Domain.Entities
{
    public class JogoJogador
    {
        public int JogoJogadorId { get; set; }
        public int JogoId { get; set; }
        public int JogadorId { get; set; }
        public virtual Jogo Jogo { get; set; }
        public virtual Jogador Jogador { get; set; }
    }
}
