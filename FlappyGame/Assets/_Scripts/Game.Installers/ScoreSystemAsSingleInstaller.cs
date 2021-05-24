using Game.Score;
using Game.View;
using Zenject;

namespace Game.Installers
{
    public class ScoreSystemAsSingleInstaller : BaseAsSingleInstaller<IScoreSystemFacade, ScoreSystemFacade>
    {
        protected override void InstallSystem(DiContainer subContainer)
        {
            base.InstallSystem(subContainer);
            BindContractAndSubstitutionWithModeAsSingle<IScoreSystem, ScoreSystem>();
            BindContractAndSubstitutionWithModeFromResolve<IGameOverView, GameOverView>();
            BindContractAndSubstitutionWithModeFromResolve<IGameplayView, GameplayView>();
        }
    }
}
