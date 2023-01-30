using System.Collections.Generic;
using UnityEngine;

namespace ItemScriptableObject
{
    [CreateAssetMenu(fileName = "ItemCarsSO", menuName = "ScriptableObject/ItemCars/ItemCarsSO")]
    public class ItemCarsSO : ScriptableObject
    {
        [Header("Макра")]
        [SerializeField] private string _mark;
        [Header("Модели")]
        [SerializeField] private ItemModelSO _model;
        [Header("Поколения")] 
        [SerializeField] private ItemGenerationSO _generation;
        [Header("Модификации")] 
        [SerializeField] private ItemModificationSO[] _modification;

        public string Mark => _mark;
        public ItemModelSO Model => _model;
        public ItemGenerationSO Generation => _generation;
        public ItemModificationSO[] Modification => _modification;

    }
}