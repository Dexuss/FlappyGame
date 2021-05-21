using Game.Installers;
using UnityEngine;
using Zenject;

namespace Game.Environment
{
    public class Character : MonoBehaviour, ICharacter
    {
        [Inject]
        private IInputSystemFacade inputSystemFacade;

        #region Fields
        [SerializeField]
        private Rigidbody2D characterRigidbody;

        private float velocity = 1.6f;
        #endregion

        void Update()
        {
            if (inputSystemFacade.IsTouchReceived())
            {
                characterRigidbody.velocity = Vector2.up * velocity;
            }
        }
    }
}
