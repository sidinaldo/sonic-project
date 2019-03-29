using AutoMapper;
using ProjetoSonic.Domain.Entities;
using ProjetoSonic.MVC.ViewModels;

namespace ProjetoSonic.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public new string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Usuario, UsuarioViewModel>();
            Mapper.CreateMap<Administrador, AdministradorViewModel>();
            Mapper.CreateMap<Bairro, BairroViewModel>();
            Mapper.CreateMap<Municipio, MunicipioViewModel>();
            Mapper.CreateMap<Estado, EstadoViewModel>();
            Mapper.CreateMap<Evento, EventoViewModel>();
            Mapper.CreateMap<Jogo, JogoViewModel>();
            Mapper.CreateMap<Jogador, JogadorViewModel>();
            Mapper.CreateMap<JogoJogadorEvento, JogoJogadorEventoViewModel>();
            Mapper.CreateMap<Campo, CampoViewModel>();
            Mapper.CreateMap<Funcao, FuncaoViewModel>();
            Mapper.CreateMap<Clube, ClubeViewModel>();
            Mapper.CreateMap<ClubeJogo, ClubeJogoViewModel>();

        }
    }        
}