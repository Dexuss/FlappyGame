using UnityEngine;
using Zenject;

namespace Game.Environment
{
    public class ConcretePipesFactory : PipesFactory<SinglePipes>
    {
        public ConcretePipesFactory(DiContainer container) : base(container) { }

        public override ISinglePipes Create(SinglePipes popupPrefab, Transform parent)
        {
            var go = container.InstantiatePrefab(popupPrefab, parent);
             pipes= go.GetComponent<SinglePipes>();
            return pipes;
        }
    }
}