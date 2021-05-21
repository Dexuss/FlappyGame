using Game.Environment;

namespace Game.Installers
{
    public class CharacterMonoBehaviourInstaller : BaseMonoBehaviourInstaller
    {
        public override void InstallSystem()
        {
            base.InstallSystem();
            BindContractAndSubstitutionWithModeFromResolve<ICharacter, Character>();
        }
    }
}
