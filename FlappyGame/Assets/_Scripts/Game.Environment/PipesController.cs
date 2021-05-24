using Game.Data;
using Game.Installers;
using System;
using System.Collections.Generic;
using System.Linq;
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

        [Inject]
        private IScoreSystemFacade scoreSystemFacade;

        [SerializeField]
        private Transform allPipesContainer;

        [SerializeField]
        private Transform beginingPoint;

        [SerializeField]
        private SinglePipes singlePipesPrefab;

        #region Fields
        private List<ISinglePipes> currentPipes = new List<ISinglePipes>();
        private float currentTime;
        private float nextPipeTime;
        #endregion

        void Start()
        {
            
        }

        void Update()
        {
            MoveCurrentPipes();
            IntervallyCreatePipes();
        }

        private void MoveCurrentPipes()
        {
            foreach (var pipes in currentPipes)
            {
                pipes.GetPipesTransform().position += Vector3.left * pipesSettings.GetPipesSpeed() * Time.deltaTime;
            }
        }

        private void IntervallyCreatePipes()
        {
            currentTime += Time.deltaTime;
            if (currentTime > nextPipeTime)
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
                ISinglePipes pipes = CreatePipes();
                InitializeBeginingPosition(pipes);
                pipes.InitialPipesData(ChooseRandomPipeData());
                currentPipes.Add(pipes);
            }
            else
            {
                ISinglePipes pipes = currentPipes[0];
                currentPipes.RemoveAt(0);
                currentPipes.Insert(pipesLimit - 1, pipes);
                InitializeBeginingPosition(pipes);
            }
        }

        private void InitializeBeginingPosition(ISinglePipes pipes)
        {
            pipes.GetPipesTransform().position = beginingPoint.position;
            pipes.GetPipesTransform().position += new Vector3(0, GenerateNextHeight(), 0);
        }

        private ISinglePipes CreatePipes()
        {
            return placeholderPipesFactory.Create(singlePipesPrefab, allPipesContainer);
        }

        private float GenerateNextHeight()
        {
            var pipesHeightMaxDifference = pipesSettings.GetPipesHeightMaxDifference();
            return UnityEngine.Random.Range(-pipesHeightMaxDifference, pipesHeightMaxDifference);
        }

        private PipesData ChooseRandomPipeData()
        {
            return pipesSettings.GetCurrentPipesData().OrderBy(guid => Guid.NewGuid()).FirstOrDefault(data => data.requiredPoints <= scoreSystemFacade.GetCurrentScore());
        }

        public void DetonatePipes()
        {
            foreach (var pipes in currentPipes.ToList())
            {
                if (pipes.IsVisible())
                {
                    pipes.ClearPipes();
                    currentPipes.Remove(pipes);
                }
            }
        }
    }
}