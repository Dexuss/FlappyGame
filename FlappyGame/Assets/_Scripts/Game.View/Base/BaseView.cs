using UnityEngine;

namespace Game.View
{
    public abstract class BaseView : MonoBehaviour
    {
        public virtual void ShowView()
        {
            if (gameObject.activeInHierarchy)
                return;
            gameObject.SetActive(true);
        }

        public virtual void HideView()
        {
            gameObject.SetActive(false);
        }
    }
}