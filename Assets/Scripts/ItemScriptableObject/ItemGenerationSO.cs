using System.Collections.Generic;
using UnityEngine;

namespace ItemScriptableObject
{
    [CreateAssetMenu(fileName = "ItemGeneration", menuName = "ScriptableObject/ItemCars/ItemGeneration")]
    public class ItemGenerationSO : ScriptableObject
    {
        [Header("Поколение")]
        [SerializeField] private ItemGenerationModification[] _generation;

        public ItemGenerationModification[] Generation => _generation;
    }
}