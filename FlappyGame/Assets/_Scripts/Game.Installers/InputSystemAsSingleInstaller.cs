using Game.Inputs;
using Zenject;

namespace Game.Installers
{
    public class InputSystemAsSingleInstaller : BaseAsSingleInstaller<IInputSystemFacade, InputSystemFacade>
    {
        protected override void InstallSystem(DiContainer subContainer)
        {
            base.InstallSystem(subContainer);
            BindContractAndSubstitutionWithModeAsSingle<IInputSystem, InputSystem>();
        }
    }
}
