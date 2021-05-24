namespace Game.Installers
{
    public interface IScoreSystemFacade
    {
        void ShowGameOverView();
        void HideGameOverView();
        void AddPoint();
        int GetCurrentScore();
        void AddBomb();
        void RemoveBomb();
        int GetCurrentBombsCount();
        void SetCurrentPoints();
        void ShowBombs();
        void HideBombs();
        void SetCurrentBombs();
    }
}