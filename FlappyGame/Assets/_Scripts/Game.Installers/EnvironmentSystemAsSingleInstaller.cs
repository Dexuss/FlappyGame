using Game.Environment;
using Zenject;

namespace Game.Installers
{
    public class EnvironmentSystemAsSingleInstaller : BaseAsSingleInstaller<IEnvironmentSystemFacade, EnvironmentSystemFacade>
    {
        protected override void InstallSystem(DiContainer subContainer)
        {
            base.InstallSystem(subContainer);
            BindContractAndSubstitutionWithModeAsSingle<IEnvironmentSystem, EnvironmentSystem>();
            BindContractAndSubstitutionWithModeFromResolve<ICharacter, Character>();
            BindContractAndSubstitutionWithModeFromResolve<IPipesController, PipesController>();
        }
    }
}
