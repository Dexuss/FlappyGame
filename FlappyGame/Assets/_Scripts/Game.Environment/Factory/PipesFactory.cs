using UnityEngine;
using Zenject;

namespace Game.Environment
{
    public abstract class PipesFactory<T> : IFactory<SinglePipes, Transform, ISinglePipes> where T : SinglePipes
    {
        protected readonly DiContainer container;
        protected SinglePipes pipes;

        protected PipesFactory(DiContainer container)
        {
            this.container = container;
        }

        public abstract ISinglePipes Create(SinglePipes pipesPrefab, Transform parent);
    }
}