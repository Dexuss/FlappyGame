using UnityEngine;

namespace Game.Environment
{
    [System.Serializable]
    public class CharacterSettings : ICharacterSettings
    {
        [SerializeField]
        private float rigidbodyGravity;

        [SerializeField]
        private float flyVelocity;

        public float GetRigidbodyGravity()
        {
            return rigidbodyGravity;
        }

        public float GetFlyVelocity()
        {
            return flyVelocity;
        }
    }
}