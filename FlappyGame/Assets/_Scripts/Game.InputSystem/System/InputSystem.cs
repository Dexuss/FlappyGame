using UnityEngine;

namespace Game.Inputs
{
    public class InputSystem : IInputSystem
    {
        public bool IsTouchReceived()
        {
            return UnityEngine.Input.touches.Length == 1 || UnityEngine.Input.GetMouseButton(0);
        }

        public void Test()
        {
            Debug.Log("test");
        }
    }
}