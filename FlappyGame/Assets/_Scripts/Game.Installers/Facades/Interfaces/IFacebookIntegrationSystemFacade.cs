namespace Game.Installers
{
    public interface IFacebookIntegrationSystemFacade
    {
        void Initialize();
        void Login();
        void Logout();
        void Share();
    }
}