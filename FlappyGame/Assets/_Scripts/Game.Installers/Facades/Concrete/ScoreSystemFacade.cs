﻿using Game.Installers;
using Game.View;

namespace Game.Score
{
    public class ScoreSystemFacade : IScoreSystemFacade
    {
        private readonly IScoreSystem scoreSystem;
        private readonly IGameOverView gameOverView;
        private readonly IGameplayView gameplayView;

        public ScoreSystemFacade(IScoreSystem scoreSystem, IGameOverView gameOverView, IGameplayView gameplayView)
        {
            this.scoreSystem = scoreSystem;
            this.gameOverView = gameOverView;
            this.gameplayView = gameplayView;
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
            gameplayView.ShowBombs();
        }

        public void HideBombs()
        {
            gameplayView.HideBombs();
        }

        public void SetCurrentBombs()
        {
            gameplayView.SetBombsCount();
        }
    }

}