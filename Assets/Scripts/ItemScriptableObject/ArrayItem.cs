using UnityEngine;

namespace ItemScriptableObject
{
    [CreateAssetMenu(fileName = "ArrayItemCars", menuName = "ScriptableObject/ItemCars/ArrayItemCarsSO")]
    public class ArrayItem : ScriptableObject
    {
        [SerializeField] private ItemCarsSO[] _itemCars;

         public ItemCarsSO[] ItemCars => _itemCars;

         
    }
}