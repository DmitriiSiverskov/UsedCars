using UnityEngine;

namespace ItemScriptableObject
{
    [CreateAssetMenu(fileName = "ItemGenerationModificationSO", menuName = "ScriptableObject/ItemCars/ItemGenerationModification")]
    public class ItemGenerationModification : ScriptableObject
    {
        [SerializeField] private string[] _generationModification;

        public string[] GenerationModification => _generationModification;
    }
}