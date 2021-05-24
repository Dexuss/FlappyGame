using Game.Environment;
using UnityEngine;


namespace Game.Installers
{
    public class PipesMonoBehaviourInstaller : BaseMonoBehaviourInstaller
    {
        [SerializeField, Header("Settings")]
        private PipesSettingsInstaller pipesSettingsInstaller;


        public override void InstallSystem()
        {
            base.InstallSystem();
            pipesSettingsInstaller.InstallBindingInSubcontainer(Container);
            BindContractAndSubstitutionWithModeFromResolve<IPipesController, PipesController>();
            subContainer.BindFactory<SinglePipes, Transform, ISinglePipes, PlaceholderPipesFactory>().FromFactory<ConcretePipesFactory>();
            BindContractAndSubstitutionWithModeFromResolve<IPipesSettings, PipesSettings>();
        }
    }
}