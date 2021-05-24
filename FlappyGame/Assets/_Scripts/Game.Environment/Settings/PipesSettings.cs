using Game.Data;
using System.Collections.Generic;
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

        [SerializeField]
        private float pipesHeightMaxDifference;

        [SerializeField]
        private List<PipesData> usedPipes = new List<PipesData>();

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

        public float GetPipesHeightMaxDifference()
        {
            return pipesHeightMaxDifference;
        }

        public List<PipesData> GetCurrentPipesData()
        {
            return usedPipes;
        }
    }
}