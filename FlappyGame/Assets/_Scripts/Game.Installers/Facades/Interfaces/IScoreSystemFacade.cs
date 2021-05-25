using Game.Data;
using System.Collections.Generic;

namespace Game.Installers
{
    public interface IScoreSystemFacade
    {
        void ShowGameplayView();
        void HideGameplayView();
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
        int GetPointsForBomb();
        void UpdateBombsCounter();
        List<int> GetHighScoreList();
        void SaveScore();
        bool IsScoreAddedToScoreboard();
        void RestartScore();
    }
}