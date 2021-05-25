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

        [SerializeField]
        private int bombsMaxCapacity;

        public int GetPointsForBomb()
        {
            return pointsForBomb;
        }

        public int GetScoreboardMaxPositions()
        {
            return scoreboardMaxPositions;
        }

        public int GetBombsMaxCapacity()
        {
            return bombsMaxCapacity;
        }
    }
}