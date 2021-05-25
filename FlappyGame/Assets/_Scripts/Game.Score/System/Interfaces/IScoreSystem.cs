using Game.Data;
using System.Collections.Generic;

namespace Game.Score
{
    public interface IScoreSystem
    {
        void AddPoint();
        int GetCurrentScore();
        void AddBomb();
        void RemoveBomb();
        int GetCurrentBombsCount();
        List<int> GetHighScoreList();
        void SaveScore();
        bool IsScoreAddedToScoreboard();
        void RestartScore();
    }
}