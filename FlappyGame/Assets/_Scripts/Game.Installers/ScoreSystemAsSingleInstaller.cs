using Game.Score;
using Game.View;
using UnityEngine;
using Zenject;

namespace Game.Installers
{
    public class ScoreSystemAsSingleInstaller : BaseAsSingleInstaller<IScoreSystemFacade, ScoreSystemFacade>
    {
        [SerializeField, Header("Settings")]
        private ScoreSettingsInstaller scoreSettingsInstaller;

        protected override void InstallSystem(DiContainer subContainer)
        {
            base.InstallSystem(subContainer);
            scoreSettingsInstaller.InstallBindingInSubcontainer(Container);
            BindContractAndSubstitutionWithModeAsSingle<IScoreSystem, ScoreSystem>();
            BindContractAndSubstitutionWithModeFromResolve<IGameOverView, GameOverView>();
            BindContractAndSubstitutionWithModeFromResolve<IGameplayView, GameplayView>();
            BindContractAndSubstitutionWithModeFromResolve<IScoreSettings, ScoreSettings>();
        }
    }
}
