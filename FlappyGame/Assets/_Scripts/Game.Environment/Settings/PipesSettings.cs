using UnityEngine;

namespace Game.Environment
{
    [System.Serializable]
    public class PipesSettings : IPipesSettings
    {
        [SerializeField]
        private float pipesSpeed;

        [SerializeField]
        private float secondsIntervalToNextPipe;

        [SerializeField, Range(4,20)]
        private int pipesLimit;

        public float GetPipesSpeed()
        {
            return pipesSpeed;
        }

        public float GetSecondsIntervalToNextPipe()
        {
            return secondsIntervalToNextPipe;
        }

        public int GetPipesLimit()
        {
            return pipesLimit;
        }
    }
}