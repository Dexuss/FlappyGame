namespace Game.View
{
    public interface IGameplayView : IBaseView
    {
        void SetScore();
        void SetBombsCount();
        void ShowBombs();
        void HideBombs();
    }
}