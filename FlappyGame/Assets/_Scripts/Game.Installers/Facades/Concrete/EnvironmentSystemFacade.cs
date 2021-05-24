using Game.Environment;

namespace Game.Installers
{
    public class EnvironmentSystemFacade : IEnvironmentSystemFacade
    {
        private readonly IEnvironmentSystem environmentSystem;

        public EnvironmentSystemFacade(IEnvironmentSystem environmentSystem)
        {
            this.environmentSystem = environmentSystem;
        }
    }
}