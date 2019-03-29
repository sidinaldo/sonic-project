using System;
using System.Collections.Generic;

namespace ProjetoSonic.Domain.Entities
{
    public class Bairro
    {
        public int BairroId { get; set; }
        public string NomeBairro { get; set; }
        public int MunicipioId { get; set; }
        public DateTime DataCadastro { get; set; }
        public int IdSessao { get; set; }
        public virtual Municipio Municipio { get; set; }
        public virtual IEnumerable<Usuario> Usuarios { get; set; }//classe bairro tem uma coleção de usuários
        public virtual IEnumerable<Clube> Clubes { get; set; }//classe bairro tem uma coleção de clubes
        public virtual IEnumerable<Jogo> Jogos { get; set; }//classe bairro tem uma coleção de jogos
        public virtual IEnumerable<Campo> Campos { get; set; }//classe bairro tem uma coleção de Campo
    }
}
