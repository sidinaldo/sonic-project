using AutoMapper;

namespace ProjetoSonic.MVC.AutoMapper
{
    //método para fazer o registro do mapeamento Domain para o ViewModel e do ViewModel para o Domain
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {          
            Mapper.Initialize(x =>
            {
                x.AddProfile<DomainToViewModelMappingProfile>();
                x.AddProfile<ViewModelToDomainMappingProfile>();
            });
           
        }

    }
}