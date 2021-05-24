using UnityEngine;

namespace Game.Score
{
    [System.Serializable]
    public class ScoreSettings : IScoreSettings
    {
        [SerializeField]
        private int pointsForBomb;

        public int GetPointsForBomb()
        {
            return pointsForBomb;
        }
    }
}