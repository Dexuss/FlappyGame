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

        [SerializeField]
        private Button playAgainButton;

        void Start()
        {
            AddButtonListeners();
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