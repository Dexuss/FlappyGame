using UnityEngine;

namespace Game.Inputs
{
    public class InputSystem : IInputSystem
    {
        #region Fields
        private float lastInputUseTime;
        #endregion

        public bool IsTouchReceived()
        {
            var isTouchRecieved = false;
            if (Input.touches.Length == 1)
            {
                if (Input.touches[0].phase == TouchPhase.Began)
                    isTouchRecieved = true;
            }
            else if (Input.GetMouseButtonDown(0))
            {
                    isTouchRecieved = true;
            }

            return isTouchRecieved;
        }

        public bool IsDoubleTap()
        {
            if (!IsTouchReceived()) 
                return false;

            var currentTime = Time.time;
            var timeSinceLastInputUse = currentTime - lastInputUseTime;
            lastInputUseTime = currentTime;

            if (timeSinceLastInputUse <= Keys.TIME_TO_DOUBLE_CLICK)
                return true;

            return false;
        }
    }
}