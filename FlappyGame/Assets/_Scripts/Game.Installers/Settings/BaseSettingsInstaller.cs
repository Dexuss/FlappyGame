using Zenject;

namespace Game.Installers
{
    public abstract class BaseSettingsInstaller<T> : ScriptableObjectInstaller
    {
        public T settings;

        public override void InstallBindings() { }

        public void InstallBindingInSubcontainer(DiContainer subContainer)
        {
            subContainer.BindInstance(settings);
        }

        public void InstallBindingInSubcontainerWithID(DiContainer subContainer, string id)
        {
            subContainer.BindInstance(settings).WithId(id);
        }
    }
}