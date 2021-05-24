using Game.Data;
using UnityEngine;

public interface ISinglePipes
{
    Transform GetPipesTransform();
    void InitialPipesData(PipesData currentPipesData);
}