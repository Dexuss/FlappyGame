using UnityEngine;

namespace Game.Environment
{
    public interface ICharacterSettings
    {
        float GetRigidbodyGravity();
        float GetFlyVelocity();
    }
}