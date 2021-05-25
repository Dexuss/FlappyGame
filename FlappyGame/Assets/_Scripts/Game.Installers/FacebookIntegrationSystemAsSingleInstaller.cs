using Game.FacebookIntegration;
using Zenject;

namespace Game.Installers
{
    public class FacebookIntegrationSystemAsSingleInstaller : BaseAsSingleInstaller<IFacebookIntegrationSystemFacade, FacebookIntegrationSystemFacade>
    {
        protected override void InstallSystem(DiContainer subContainer)
        {
            base.InstallSystem(subContainer);
            BindContractAndSubstitutionWithModeAsSingle<IFacebookIntegrationSystem, FacebookIntegrationSystem>();
        }
    }
}