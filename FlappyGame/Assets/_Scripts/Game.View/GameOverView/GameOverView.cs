using Game.Installers;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Zenject;

namespace Game.View
{
    public class GameOverView : BaseView, IGameOverView
    {
        [Inject]
        private IEnvironmentSystemFacade environmentSystemFacade;

        [Inject]
        private IScoreSystemFacade scoreSystemFacade;

        [SerializeField]
        private Button playAgainButton;

        [SerializeField]
        private GameObject scoreBoardNotification;

        [SerializeField]
        private Text score;

        private void Start()
        {
            AddButtonListeners();
        }

        public override void ShowView()
        {
            score.text = scoreSystemFacade.GetCurrentScore().ToString();
            scoreSystemFacade.SaveScore();
            ShowHighScoreNotification();
            scoreSystemFacade.RestartScore();
            base.ShowView();
        }

        private void ShowHighScoreNotification()
        {
            if (scoreSystemFacade.IsScoreAddedToScoreboard())
                scoreBoardNotification.SetActive(true);
        }

        private void AddButtonListeners()
        {
            playAgainButton.onClick.AddListener(PlayAgain);
        }

        public void FreezeScene()
        {
            Time.timeScale = 0;
        }

        public void PlayAgain()
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(0);
        }
    }
}