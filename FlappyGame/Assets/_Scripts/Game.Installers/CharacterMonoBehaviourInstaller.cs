using Game.Environment;
using UnityEngine;

namespace Game.Installers
{
    public class CharacterMonoBehaviourInstaller : BaseMonoBehaviourInstaller
    {
        [SerializeField, Header("Settings")]
        private CharacterSettingsInstaller characterSettingsInstaller;

        public override void InstallSystem()
        {
            base.InstallSystem();
            BindContractAndSubstitutionWithModeFromResolve<ICharacter, Character>();
            characterSettingsInstaller.InstallBindingInSubcontainer(Container);
            BindContractAndSubstitutionWithModeFromResolve<ICharacterSettings, CharacterSettings>();
        }
    }
}