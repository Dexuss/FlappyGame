using Game.Inputs;
using Game.Installers;
using UnityEngine;
using Zenject;

namespace Game.Environment
{
    public class Character : MonoBehaviour, ICharacter
    {
        [Inject]
        private IInputSystemFacade inputSystemFacade;

        [Inject]
        private ICharacterSettings characterSettings;

        [Inject]
        private IScoreSystemFacade scoreSystemFacade;

        #region Fields
        [SerializeField]
        private Rigidbody2D characterRigidbody;
        #endregion

        void Start()
        {
            characterRigidbody.gravityScale = characterSettings.GetRigidbodyGravity();
        }

        void Update()
        {
            if (inputSystemFacade.IsTouchReceived())
            {
                characterRigidbody.velocity = Vector2.up * characterSettings.GetFlyVelocity();
            }
        }

        void OnCollisionEnter2D(Collision2D collider)
        {
            scoreSystemFacade.ShowGameOverView();
        }
    }
}
