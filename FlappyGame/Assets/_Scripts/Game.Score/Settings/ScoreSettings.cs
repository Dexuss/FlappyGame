using UnityEngine;

namespace Game.Score
{
    [System.Serializable]
    public class ScoreSettings : IScoreSettings
    {
        [SerializeField]
        private int pointsForBomb;

        [SerializeField]
        private int scoreboardMaxPositions;

        public int GetPointsForBomb()
        {
            return pointsForBomb;
        }

        public int GetScoreboardMaxPositions()
        {
            return scoreboardMaxPositions;
        }
    }
}