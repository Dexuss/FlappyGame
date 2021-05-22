using Game.Data;
using UnityEngine;
using Zenject;

public class SinglePipes : MonoBehaviour, ISinglePipes
{
    [SerializeField]
    private Transform pipesTransform;

    [SerializeField]
    private SpriteRenderer topPipeSprite;

    [SerializeField]
    private SpriteRenderer bottomPipeSprite;

    private PipesData currentPipesData;

    public Transform GetPipesTransform()
    {
        return pipesTransform;
    }

    public void InitialPipesData(PipesData currentPipesData)
    {
        var pipeSprite = currentPipesData.pipeSprite; ;
        var pipeColor = currentPipesData.pipesColor;
        topPipeSprite.sprite = pipeSprite;
        bottomPipeSprite.sprite = pipeSprite;
        topPipeSprite.color = pipeColor;
        bottomPipeSprite.color = pipeColor;
        this.currentPipesData = currentPipesData;
    }

    public int GetRequiredPoints()
    {
        return currentPipesData.requiredPoints;
    }
}
