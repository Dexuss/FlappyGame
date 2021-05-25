using Game.Data;
using Game.Installers;
using Game.View;
using System.Collections.Generic;

namespace Game.Score
{
    public class ScoreSystemFacade : IScoreSystemFacade
    {
        private readonly IScoreSystem scoreSystem;
        private readonly IGameOverView gameOverView;
        private readonly IGameplayView gameplayView;
        private readonly IStartView startView;
        private readonly IScoreSettings scoreSettings;

        public ScoreSystemFacade(IScoreSystem scoreSystem, IGameOverView gameOverView, IGameplayView gameplayView, IScoreSettings scoreSettings, IStartView startView)
        {
            this.scoreSystem = scoreSystem;
            this.gameOverView = gameOverView;
            this.gameplayView = gameplayView;
            this.scoreSettings = scoreSettings;
            this.startView = startView;
        }

        public void ShowGameplayView()
        {
            gameplayView.ShowView();
        }

        public void HideGameplayView()
        {
            gameplayView.HideView();
        }

        public void ShowGameOverView() 
        {
            gameplayView.HideView();
            gameOverView.ShowView();
            gameOverView.FreezeScene();
        }

        public void HideGameOverView()
        {
            gameOverView.HideView();
            gameplayView.ShowView();
        }

        public void AddPoint()
        {
            scoreSystem.AddPoint();
        }

        public int GetCurrentScore()
        {
            return scoreSystem.GetCurrentScore();
        }

        public void AddBomb()
        {
            scoreSystem.AddBomb();
        }

        public void RemoveBomb()
        {
            scoreSystem.RemoveBomb();
        }

        public int GetCurrentBombsCount()
        {
            return scoreSystem.GetCurrentBombsCount();
        }

        public void SetCurrentPoints()
        {
            gameplayView.SetScore();
        }

        public void ShowBombs()
        {
            UpdateBombsCounter();
            gameplayView.ShowBombs();
        }

        public void HideBombs()
        {
            gameplayView.HideBombs();
        }

        public void UpdateBombsCounter()
        {
            gameplayView.UpdateBombsCounter();
        }

        public void SetCurrentBombs()
        {
            gameplayView.SetBombsCount();
        }

        public int GetPointsForBomb()
        {
            return scoreSettings.GetPointsForBomb();
        }

        public List<int> GetHighScoreList()
        {
            return scoreSystem.GetHighScoreList();
        }

        public void SaveScore()
        {
            scoreSystem.SaveScore();
        }

        public bool IsScoreAddedToScoreboard()
        {
            return scoreSystem.IsScoreAddedToScoreboard();
        }

        public void RestartScore()
        {
            scoreSystem.RestartScore();
        }
    }
}