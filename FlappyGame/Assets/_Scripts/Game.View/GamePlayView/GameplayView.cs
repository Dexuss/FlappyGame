using Game.Installers;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Game.View
{
    public class GameplayView : BaseView, IGameplayView
    {
        [Inject]
        private IScoreSystemFacade scoreSystemFacade;

        [SerializeField]
        private Text playerScore;

        [SerializeField]
        private Text bombsCount;

        [SerializeField]
        private GameObject bombs;

        #region Fields
        private bool isBombsVisible;
        #endregion  

        public void SetScore()
        {
            playerScore.text = scoreSystemFacade.GetCurrentScore().ToString();
        }

        public void SetBombsCount()
        {
            bombsCount.text = scoreSystemFacade.GetCurrentBombsCount().ToString();
        }

        public void ShowBombs()
        {
            if (isBombsVisible) return;
            bombs.SetActive(true);
            isBombsVisible = true;
        }

        public void HideBombs()
        {
            bombs.SetActive(false);
            isBombsVisible = false;
        }
    }
}