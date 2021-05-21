using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Game.Environment
{
    public class PipesController : MonoBehaviour, IPipesController
    {
        [Inject]
        private PlaceholderPipesFactory placeholderPipesFactory;

        [Inject]
        private IPipesSettings pipesSettings;

        [SerializeField]
        private List<SinglePipes> pipesTypes = new List<SinglePipes>();

        [SerializeField]
        private Transform allPipesContainer;

        [SerializeField]
        private Transform beginingPoint;

        [SerializeField]
        private Transform middlePoint;

        [SerializeField]
        private Transform endPoint;

        [SerializeField]
        private SinglePipes singlePipesPrefab;

        #region Fields
        private List<ISinglePipes> currentPipes = new List<ISinglePipes>();
        private float lastPipeCreationTime;
        private float nextPipeTime;
        #endregion

        void Start()
        {

        }

        void Update()
        {
            foreach (var pipes in currentPipes)
            {
                pipes.GetPipesTransform().position += Vector3.left * pipesSettings.GetPipesSpeed() * Time.deltaTime;
            }

            var elapsedTime = Time.time - lastPipeCreationTime;
            if (Time.time > nextPipeTime)
            {
                nextPipeTime += pipesSettings.GetSecondsIntervalToNextPipe();
                CreateNewPipes();
            }
        }

        private void CreateNewPipes()
        {
            var pipesLimit = pipesSettings.GetPipesLimit();
            if (currentPipes.Count < pipesLimit)
            {
                ISinglePipes pipe = CreatePipes();
                pipe.GetPipesTransform().position = beginingPoint.position;
                currentPipes.Add(pipe);
                lastPipeCreationTime = Time.time;
            }
            else
            {
                ISinglePipes pipes = currentPipes[0];
                currentPipes.RemoveAt(0);
                currentPipes.Insert(pipesLimit - 1, pipes);
                pipes.GetPipesTransform().position = beginingPoint.position;
                lastPipeCreationTime = Time.time;
            }
        }

        private ISinglePipes CreatePipes()
        {
            return placeholderPipesFactory.Create(singlePipesPrefab, allPipesContainer);
        }
    }
}