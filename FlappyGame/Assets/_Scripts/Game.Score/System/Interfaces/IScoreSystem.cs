namespace Game.Score
{
    public interface IScoreSystem
    {
        void AddPoint();
        int GetCurrentScore();
        void AddBomb();
        void RemoveBomb();
        int GetCurrentBombsCount();
    }
}