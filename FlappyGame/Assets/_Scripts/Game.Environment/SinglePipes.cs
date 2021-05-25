using Game.Data;
using UnityEngine;

public class SinglePipes : MonoBehaviour, ISinglePipes
{
    [SerializeField]
    private Transform pipesTransform;

    [SerializeField]
    private SpriteRenderer topPipeSprite;

    [SerializeField]
    private SpriteRenderer bottomPipeSprite;

    [SerializeField]
    private BoxCollider2D scoreCollider;

    [SerializeField]
    private BoxCollider2D pipeTopCollider;

    [SerializeField]
    private BoxCollider2D pipeBottomCollider;

    [SerializeField]
    private Renderer pipesRenderer;

    private PipesData currentPipesData;

    public void ClearPipes()
    {
        Destroy(gameObject);
    }

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

    public bool IsVisible()
    {
        Vector3 screenPoint = Camera.main.WorldToViewportPoint(pipesTransform.position);
        return screenPoint.z > 0 && screenPoint.x > 0 && screenPoint.x < 1 && screenPoint.y > 0 && screenPoint.y < 1;
    }
}
