using Game.Inputs;

namespace Game.Installers
{
    public class InputSystemFacade : IInputSystemFacade
    {
        private readonly IInputSystem inputSystem;

        public InputSystemFacade(IInputSystem inputSystem)
        {
            this.inputSystem = inputSystem;
        }

        public bool IsTouchReceived()
        {
            return inputSystem.IsTouchReceived();
        }
    }
}