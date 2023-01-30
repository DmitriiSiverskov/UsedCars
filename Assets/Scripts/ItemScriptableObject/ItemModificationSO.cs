using System.Collections.Generic;
using UnityEngine;

namespace ItemScriptableObject
{
    [CreateAssetMenu(fileName = "ItemModificationSO", menuName = "ScriptableObject/ItemCars/ItemModification")]
    public class ItemModificationSO : ScriptableObject
    {
        [Header("Модификации")]
        [SerializeField] private string[] _modification;

        public string[] Modification => _modification;
    }
}