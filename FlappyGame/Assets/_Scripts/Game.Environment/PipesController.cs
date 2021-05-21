using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Game.Environment
{
    public class PipesController : MonoBehaviour, IPipesController
    {
        [Inject]
        private PlaceholderPipesFactory placeholderPipesFactory;

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

        void Start()
        {

        }

        void Update()
        {

        }

        private ISinglePipes CreatePipes()
        {
            return placeholderPipesFactory.Create(singlePipesPrefab, allPipesContainer);
        }
    }
}