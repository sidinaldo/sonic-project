
using System;
using System.Collections.Generic;

namespace ProjetoSonic.Domain.Entities
{
    public class Jogo
    {
        //public Jogo()
        //{
        //    this.Jogadores = new HashSet<Jogador>();
        //}

        
        public int JogoId  { get; set; }
        public DateTime DataJogo  { get; set; }
        public string HoraJogo { get; set; }
        public int BairroId { get; set; }       
        public DateTime DataCadastro { get; set; }
        public virtual Bairro Bairro { get; set; }
        public int IdSessao { get; set; }
        public int TimeA { get; set; }
        public int TimeB { get; set; }
        public int GolTimeA { get; set; }
        public int GolTimeB { get; set; }
        public string ResultadoTimeA { get; set; }
        public string ResultadoTimeB { get; set; }
        public int CampoId { get; set; }
        public virtual Campo Campo { get; set; }
        public virtual Clube Clube { get; set; }

        public virtual IEnumerable<Clube> Clubes { get; set; }
        public virtual IEnumerable<Jogador> Jogadores { get; set; }
        public virtual IEnumerable<JogoJogador> JogoJogadores { get; set; }

        //public virtual ICollection<Jogador> Jogadores { get; set; }

        public void ResultadoDoJogo()
        {
            if (GolTimeA > GolTimeB )
            {
                ResultadoTimeA = "Vitória";
                ResultadoTimeB = "Derrota";
            }
            if (GolTimeA < GolTimeB)
            {
                ResultadoTimeA = "Derrota";
                ResultadoTimeB = "Vitória";
            }
            if (GolTimeA == GolTimeB)
            {
                ResultadoTimeA = "Empate";
                ResultadoTimeB = "Empate";
            }
        }

    }
}
