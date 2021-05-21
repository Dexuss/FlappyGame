using UnityEngine;

namespace Game.Inputs
{
    public class InputSystem : IInputSystem
    {
        #region Fields
        private bool isTouchedOnce;
        #endregion
        public bool IsTouchReceived()
        {
            if (isTouchedOnce && Input.touchCount == 0)
            {
                isTouchedOnce = false;
            }
            else if (!isTouchedOnce && Input.touchCount > 0)
            {
                isTouchedOnce = true;
            }
            return isTouchedOnce || Input.GetMouseButtonDown(0);
        }
    }
}