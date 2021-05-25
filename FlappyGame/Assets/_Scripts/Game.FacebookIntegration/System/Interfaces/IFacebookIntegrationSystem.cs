namespace Game.FacebookIntegration
{
    public interface IFacebookIntegrationSystem
    {
        void Initialize();
        void Login();
        void Logout();
        void Share();
    }
}