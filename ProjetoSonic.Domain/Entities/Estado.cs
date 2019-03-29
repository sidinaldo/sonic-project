using System;
using System.Collections.Generic;

namespace ProjetoSonic.Domain.Entities
{
    public class Estado
    {
        public int EstadoId { get; set; }
        public string NomeEstado { get; set; }
        public string Sigla { get; set; }
        public DateTime DataCadastro { get; set; }
        public int IdSessao { get; set; }
        public virtual IEnumerable<Municipio> Municipios { get; set; }//classe Estado tem uma coleção de Municipio
    }
}
