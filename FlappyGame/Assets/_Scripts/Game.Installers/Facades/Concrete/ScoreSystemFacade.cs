using Game.Installers;
using Game.View;

namespace Game.Score
{
    public class ScoreSystemFacade : IScoreSystemFacade
    {
        private readonly IScoreSystem scoreSystem;
        private readonly IGameOverView gameOverView;

        public ScoreSystemFacade(IScoreSystem scoreSystem, IGameOverView gameOverView)
        {
            this.scoreSystem = scoreSystem;
            this.gameOverView = gameOverView;
        }

        public void ShowGameOverView() 
        {
            gameOverView.ShowView();
            gameOverView.FreezeScene();
        }

        public void HideGameOverView()
        {
            gameOverView.HideView();
        }
    }

}