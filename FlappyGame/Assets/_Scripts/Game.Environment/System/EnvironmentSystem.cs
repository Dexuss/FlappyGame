using Game.Inputs;
using Game.Installers;
using UnityEngine;
using Zenject;

namespace Game.Environment
{
    public class EnvironmentSystem : IEnvironmentSystem
    {
        private IPipesController pipesController;
        private ICharacter character;

        [Inject]
        public EnvironmentSystem(IPipesController pipesController, ICharacter character)
        {
            this.pipesController = pipesController;
            this.character = character;
        }
    }
}