using Game.Environment;
using UnityEngine;

namespace Game.Installers
{
    public class CharacterMonoBehaviourInstaller : BaseMonoBehaviourInstaller
    {
        [SerializeField, Header("Settings")]
        private CharacterSettingsInstaller auctionsSystemSettingsInstaller;

        public override void InstallSystem()
        {
            base.InstallSystem();
            BindContractAndSubstitutionWithModeFromResolve<ICharacter, Character>();
            auctionsSystemSettingsInstaller.InstallBindingInSubcontainer(Container);
            BindContractAndSubstitutionWithModeFromResolve<ICharacterSettings, CharacterSettings>();
        }
    }
}
