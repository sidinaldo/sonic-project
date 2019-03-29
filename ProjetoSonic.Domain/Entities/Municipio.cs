
using System;
using System.Collections.Generic;

namespace ProjetoSonic.Domain.Entities
{
   public class Municipio
    {
       public int MunicipioId { get; set; }
       public string NomeMunicipio { get; set; }
       public DateTime DataCadastro { get; set; }       
       public int EstadoId { get; set; }
       public virtual Estado Estado { get; set; }
       public int IdSessao { get; set; }

       public virtual IEnumerable<Bairro> Bairros { get; set; }//classe município tem uma coleção de bairro
    }
}
