using System.Collections.Generic;
using UnityEngine;

namespace ItemScriptableObject
{
    [CreateAssetMenu(fileName = "ItemModel", menuName = "ScriptableObject/ItemCars/ItemModel")]
    public class ItemModelSO : ScriptableObject
    {
        [Header("Модели")]
        [SerializeField] private string[] _model;

        public string[] Model => _model;
    }
}