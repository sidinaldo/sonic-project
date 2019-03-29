using ProjetoSonic.Application;
using ProjetoSonic.Application.Interface;
using ProjetoSonic.Domain.Interfaces;
using ProjetoSonic.Domain.Interfaces.Repositories;
using ProjetoSonic.Domain.Interfaces.Services;
using ProjetoSonic.Domain.Services;
using ProjetoSonic.Infra.Data.Repositories;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(ProjetoSonic.MVC.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(ProjetoSonic.MVC.App_Start.NinjectWebCommon), "Stop")]

namespace ProjetoSonic.MVC.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            kernel.Bind<IUsuarioAppService>().To<UsuarioAppService>();
            kernel.Bind<IAdministradorAppService>().To<AdministradorAppService>();
            kernel.Bind<IBairroAppService>().To<BairroAppService>();
            kernel.Bind<IMunicipioAppService>().To<MunicipioAppService>();
            kernel.Bind<IEstadoAppService>().To<EstadoAppService>();
            kernel.Bind<IEventoAppService>().To<EventoAppService>();
            kernel.Bind<IClubeAppService>().To<ClubeAppService>();
            kernel.Bind<IJogoAppService>().To<JogoAppService>();
            kernel.Bind<IJogadorAppService>().To<JogadorAppService>();
            //kernel.Bind<IJogoJogadorEventoAppService>().To<JogoJogadorEventoAppService>();
            kernel.Bind<ICampoAppService>().To<CampoAppService>();
            kernel.Bind<IFuncaoAppService>().To<FuncaoAppService>();
            kernel.Bind<IClubeJogoAppService>().To<ClubeJogoAppService>();
            kernel.Bind<IJogoJogadorAppService>().To<JogoJogadorAppService>();

            kernel.Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            kernel.Bind<IUsuarioService>().To<UsuarioService>();
            kernel.Bind<IAdministradorService>().To<AdministradorService>();
            kernel.Bind<IBairroService>().To<BairroService>();
            kernel.Bind<IMunicipioService>().To<MunicipioService>();
            kernel.Bind<IEstadoService>().To<EstadoService>();
            kernel.Bind<IEventoService>().To<EventoService>();
            kernel.Bind<IClubeService>().To<ClubeService>();
            kernel.Bind<IJogoService>().To<JogoService>();
            kernel.Bind<IJogadorService>().To<JogadorService>();
            //kernel.Bind<IJogoJogadorEventoService>().To<JogoJogadorEventoService>();
            kernel.Bind<ICampoService>().To<CampoService>();
            kernel.Bind<IFuncaoService>().To<FuncaoService>();
            kernel.Bind<IClubeJogoService>().To<ClubeJogoService>();
            kernel.Bind<IJogoJogadorService>().To<JogoJogadorService>();

            kernel.Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            kernel.Bind<IUsuarioRepository>().To<UsuarioRepository>();
            kernel.Bind<IAdministradorRepository>().To<AdministradorRepository>();
            kernel.Bind<IBairroRepository>().To<BairroRepository>();
            kernel.Bind<IMunicipioRepository>().To<MunicipioRepository>();
            kernel.Bind<IEstadoRepository>().To<EstadoRepository>();
            kernel.Bind<IEventoRepository>().To<EventoRepository>();
            kernel.Bind<IClubeRepository>().To<ClubeRepository>();
            kernel.Bind<IJogoRepository>().To<JogoRepository>();
            kernel.Bind<IJogadorRepository>().To<JogadorRepository>();
            //kernel.Bind<IJogoJogadorEventoRepository>().To<JogoJogadorEventoRepository>();
            kernel.Bind<ICampoRepository>().To<CampoRepository>();
            kernel.Bind<IFuncaoRepository>().To<FuncaoRepository>();
            kernel.Bind<IClubeJogoRepository>().To<ClubeJogoRepository>();
            kernel.Bind<IJogoJogadorRepository>().To<JogoJogadorRepository>();


        }        
    }
}
