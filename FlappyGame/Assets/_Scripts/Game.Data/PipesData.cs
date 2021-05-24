using UnityEngine;

namespace Game.Data
{
    [CreateAssetMenu(menuName = "AddPipesData/New Pipes")]
    public class PipesData : ScriptableObject
    {
        public Sprite pipeSprite;
        public Color pipesColor;
        public int requiredPoints;
    }
}