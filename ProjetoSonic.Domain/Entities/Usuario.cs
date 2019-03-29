using System;
using System.Collections.Generic;


namespace ProjetoSonic.Domain.Entities
{
    public class Usuario
    {
        //public Usuario(string nomeusuario, string emailUsuario, string senhaUsuario, string tipo, string timeUsuario, bool ativo)
        //{
        //    this.NomeUsuario        = nomeusuario;
        //    this.EmailUsuario       = emailUsuario;
        //    this.SenhaUsuario       = senhaUsuario;
        //    this.Tipo               = tipo;
        //    this.TimeUsuario        = timeUsuario;
        //    this.Ativo              = ativo;
        //}

        public int UsuarioId { get; set; }
        public string NomeUsuario { get; set; }
        public string EmailUsuario { get; set; }
        public string SenhaUsuario { get; set; }
        public string Tipo { get; set; }
        public string ClubeQueTorce { get; set; }
        public int BairroId { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }
        public int IdSessao { get; set; }

        public virtual IEnumerable<Administrador> Administradores  { get; set; }//classe usuaio tem uma coleção de Administradores
        public virtual Bairro Bairro { get; set; }   
        

        //public void SetPassword(string senha, string ConfirmaSenha)
        //{
        //    if (string.IsNullOrEmpty(senha))
        //    {
        //        throw new Exception("Senha Inválida");
        //    }

        //}
    }
}
