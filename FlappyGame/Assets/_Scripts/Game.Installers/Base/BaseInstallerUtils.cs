using Zenject;

namespace Game.Installers
{
    public class BaseInstallerUtils : MonoInstaller
    {
        protected DiContainer subContainer;

        protected void BindContractAndSubstitutionWithModeFromInstance<TContract, TConcrete>(TConcrete instance)
            where TConcrete : TContract
            where TContract : class
        {
            subContainer.Bind<TContract>().To<TConcrete>().FromInstance(instance);
        }

        protected void BindContractAndSubstitutionWithModeAsSingle<TContract, TConcrete>()
            where TConcrete : TContract
            where TContract : class
        {
            subContainer.Bind<TContract>().To<TConcrete>().AsSingle();

        }

        protected void BindContractAndSubstitutionWithModeFromResolve<TContract, TConcrete>()
            where TConcrete : TContract
            where TContract : class
        {
            subContainer.Bind<TContract>().To<TConcrete>().FromResolve();
        }
    }
}