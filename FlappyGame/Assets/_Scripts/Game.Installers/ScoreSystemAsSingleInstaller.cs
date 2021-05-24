using Game.Score;
using Zenject;

namespace Game.Installers
{
    public class ScoreSystemAsSingleInstaller : BaseAsSingleInstaller<IScoreSystemFacade, ScoreSystemFacade>
    {
        protected override void InstallSystem(DiContainer subContainer)
        {
            base.InstallSystem(subContainer);
            BindContractAndSubstitutionWithModeAsSingle<IScoreSystem, ScoreSystem>();
        }
    }
}
