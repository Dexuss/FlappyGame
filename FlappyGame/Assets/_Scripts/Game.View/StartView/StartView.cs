using Game.Installers;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Game.View
{
    public class StartView : BaseView, IStartView
    {
        [Inject]
        private IScoreSystemFacade scoreSystemFacade;

        [SerializeField]
        private Button playButton;

        [SerializeField]
        private Transform scoresContainer;

        [SerializeField]
        private Text scoreBoardPosition;

        [SerializeField]
        private GameObject scoreboard;

        private void Start()
        {
            Time.timeScale = 0;
            playButton.onClick.AddListener(StartGame);
            InitializeScoreboard();
        }

        private void StartGame()
        {
            Time.timeScale = 1;
            HideView();
            scoreSystemFacade.ShowGameplayView();
        }

        private void InitializeScoreboard()
        {
            var currentHighscores = scoreSystemFacade.GetHighScoreList();

            if (currentHighscores.Count == 0)
            {
                scoreboard.SetActive(false);
            }
            else
            {
                scoreboard.SetActive(true); ;
            }

            foreach (var score in currentHighscores)
            {
                var scorePosition = Instantiate(scoreBoardPosition, scoresContainer);
                scorePosition.text = score.ToString();
            }
        }
    }
}