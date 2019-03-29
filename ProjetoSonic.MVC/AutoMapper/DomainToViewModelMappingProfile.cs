using AutoMapper;
using ProjetoSonic.Domain.Entities;
using ProjetoSonic.MVC.ViewModels;

namespace ProjetoSonic.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public new string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<UsuarioViewModel, Usuario>();
            Mapper.CreateMap<AdministradorViewModel, Administrador>();
            Mapper.CreateMap<BairroViewModel, Bairro>();
            Mapper.CreateMap<MunicipioViewModel, Municipio>();
            Mapper.CreateMap<EstadoViewModel, Estado>();
            Mapper.CreateMap<EventoViewModel, Evento>();
            Mapper.CreateMap<JogoViewModel, Jogo>();
            Mapper.CreateMap<JogadorViewModel, Jogador>();
            Mapper.CreateMap<JogoJogadorEventoViewModel, JogoJogadorEvento>();
            Mapper.CreateMap<CampoViewModel, Campo>();
            Mapper.CreateMap<FuncaoViewModel, Funcao>();
            Mapper.CreateMap<ClubeViewModel, Clube>();
            Mapper.CreateMap<ClubeJogoViewModel, ClubeJogo>();

        }
    }
}