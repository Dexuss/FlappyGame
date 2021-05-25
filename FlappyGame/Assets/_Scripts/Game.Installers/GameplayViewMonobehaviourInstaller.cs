using Game.View;

namespace Game.Installers
{
    public class GameplayViewMonobehaviourInstaller : BaseMonoBehaviourInstaller
    {
        public override void InstallSystem()
        {
            base.InstallSystem();
            BindContractAndSubstitutionWithModeFromResolve<IGameplayView, GameplayView>();
        }
    }
}