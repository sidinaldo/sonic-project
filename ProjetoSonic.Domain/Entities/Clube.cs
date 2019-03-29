
using System;
using System.Collections.Generic;

namespace ProjetoSonic.Domain.Entities
{
    public class Clube
    {
        //public Clube()
        //{
        //    Jogo        = new List<Jogo>();
        //    Jogador     = new List<Jogador>();
        //    Ativo       = true; 
        //}
        public int ClubeId { get; set; }
        public string NomeClube { get; set; }
        public DateTime Fundacao { get; set; }
        public int BairroId { get; set; }
        public string Historia { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }
        public int IdSessao { get; set; }       
        public virtual Bairro Bairro { get; set; }               
        public virtual IEnumerable<Jogador> Jogadores { get; set; }//classe clube tem uma coleção de jogador
        public virtual IEnumerable<Jogo> Jogos { get; set; }

    }
}
