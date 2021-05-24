namespace Game.Score
{
    public class ScoreSystem : IScoreSystem
    {
        #region Fields
        private int playerScore;
        private int bombsCount;
        #endregion

        public void AddPoint()
        {
            playerScore++;
        }

        public void AddBomb()
        {
            bombsCount++;
        }

        public void RemoveBomb()
        {
            bombsCount--;
        }

        public int GetCurrentScore()
        {
            return playerScore;
        }

        public int GetCurrentBombsCount()
        {
            return bombsCount;
        }
    }
}