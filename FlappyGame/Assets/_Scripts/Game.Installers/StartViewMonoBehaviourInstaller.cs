using Game.View;

namespace Game.Installers
{
    public class StartViewMonoBehaviourInstaller : BaseMonoBehaviourInstaller
    {
        public override void InstallSystem()
        {
            base.InstallSystem();
            BindContractAndSubstitutionWithModeFromResolve<IStartView, StartView>();
        }
    }
}