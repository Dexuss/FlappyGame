using Zenject;

namespace Game.Installers
{
    public class BaseAsSingleInstaller<TContractFacade, TConcreteFacade> : BaseInstallerUtils
        where TConcreteFacade : TContractFacade
        where TContractFacade : class
    {
        public override void InstallBindings()
        {
            Container.Bind<TContractFacade>().FromSubContainerResolve().ByMethod(InstallSystem).AsSingle();
        }

        protected virtual void InstallSystem(DiContainer subContainer)
        {
            this.subContainer = subContainer;
            BindContractAndSubstitutionWithModeAsSingle<TContractFacade, TConcreteFacade>();
        }
    }
}
