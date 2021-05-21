namespace Game.Installers
{
	public class BaseMonoBehaviourInstaller : BaseInstallerUtils
	{
		public override void InstallBindings()
		{
			InstallSystem();
		}

		public virtual void InstallSystem()
		{
			subContainer = Container;
		}
	}
}
