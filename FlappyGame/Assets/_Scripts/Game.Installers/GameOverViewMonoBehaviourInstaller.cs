using Game.View;

namespace Game.Installers
{
    public class GameOverViewMonoBehaviourInstaller : BaseMonoBehaviourInstaller
    {
        public override void InstallSystem()
        {
            base.InstallSystem();
            BindContractAndSubstitutionWithModeFromResolve<IGameOverView, GameOverView>();
        }
    }
}