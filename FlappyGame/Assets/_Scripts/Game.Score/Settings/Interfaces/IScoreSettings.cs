using UnityEngine;

namespace Game.Score
{
    public interface IScoreSettings
    {
        int GetPointsForBomb();
        int GetScoreboardMaxPositions();
    }
}