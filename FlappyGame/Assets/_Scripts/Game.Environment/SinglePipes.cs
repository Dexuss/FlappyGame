using UnityEngine;

public class SinglePipes : MonoBehaviour, ISinglePipes
{
    [SerializeField]
    private Transform pipesTransform;

    [SerializeField]
    private SpriteRenderer topPipeSprite;

    [SerializeField]
    private SpriteRenderer bottomPipeSprite;

    //private PipesData currentPipesData;

    public Transform GetPipesTransform()
    {
        return pipesTransform;
    }
}
