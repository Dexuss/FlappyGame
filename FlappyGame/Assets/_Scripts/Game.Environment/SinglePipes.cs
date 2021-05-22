using UnityEngine;

public class SinglePipes : MonoBehaviour, ISinglePipes
{
    [SerializeField]
    private Transform pipesTransform;

    public Transform GetPipesTransform()
    {
        return pipesTransform;
    }
}
