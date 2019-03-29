using System;
using System.Collections.Generic;

namespace ProjetoSonic.Domain.Entities
{
    public class Campo
    {
        public int CampoId { get; set; }
        public string NomeCampo { get; set; }
        public int BairroId { get; set; }
        public DateTime DataCadastro { get; set; }
        public virtual  Bairro Bairro { get; set; }
        public int IdSessao { get; set; }
        public virtual IEnumerable<Jogo> Jogos { get; set; }



    }
}
