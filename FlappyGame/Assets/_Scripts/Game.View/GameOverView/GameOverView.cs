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

        [Inject]
        private IFacebookIntegrationSystemFacade facebookIntegrationSystemFacade;

        [SerializeField]
        private Button playAgainButton;

        [SerializeField]
        private Button facebookShareButton;

        [SerializeField]
        private GameObject scoreBoardNotification;

        [SerializeField]
        private Text score;

        private void Start()
        {
            AddButtonsListeners();
        }

        public override void ShowView()
        {
            facebookIntegrationSystemFacade.Initialize();
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

        private void AddButtonsListeners()
        {
            playAgainButton.onClick.AddListener(PlayAgain);
            facebookShareButton.onClick.AddListener(facebookIntegrationSystemFacade.Share);
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