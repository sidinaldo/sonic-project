
using System;
using System.Collections.Generic;

namespace ProjetoSonic.Domain.Entities
{
   public class Jogador
    {
        //public Jogador()
        //{           
        //}

       public int JogadorId { get; set; }      
       public string ApelidoJogador { get; set; }
       public string AlturaJogador { get; set; }
       public float PesoJogador { get; set; }
       public DateTime DataNascimneto { get; set; }
       public string PeDominante { get; set; }
       public string Posicaojogador { get; set; }
       public int UsuarioId { get; set; }
       public int ClubeId { get; set; }
       public DateTime DataCadastro { get; set; }
       public bool Ativo { get; set; }
       public int IdSessao { get; set; }
       public virtual Usuario Usuario { get; set; }
       public virtual Clube Clube { get; set; }

       public virtual IEnumerable<Jogo> Jogos { get; set; }
       public virtual IEnumerable<JogoJogador> JogoJogadores { get; set; }

       //public virtual ICollection<Jogo> Jogos { get; set; }

       
    }
}
