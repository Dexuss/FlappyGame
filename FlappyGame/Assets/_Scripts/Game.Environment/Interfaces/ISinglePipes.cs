using Game.Data;
using UnityEngine;

public interface ISinglePipes
{
    void InitialPipesData(PipesData currentPipesData);
    void ClearPipes();
    Transform GetPipesTransform();
}