using UnityEngine;

namespace Game.Inputs
{
    public class InputSystem : IInputSystem
    {
        #region Fields
        private float timeToDoubleClick = 0.2f;
        private bool isTouchedOnce;
        private float lastInputUseTime;
        #endregion

        public bool IsTouchReceived()
        {
            return Input.touches.Length == 1 || Input.GetMouseButtonDown(0);
        }

        public bool IsDoubleTap()
        {
            if (!IsTouchReceived()) 
                return false;
            var currentTime = Time.time;
            var timeSinceLastInputUse = currentTime - lastInputUseTime;
            lastInputUseTime = currentTime;
            if (timeSinceLastInputUse <= timeToDoubleClick)
                return true;
            return false;
        }
    }
}