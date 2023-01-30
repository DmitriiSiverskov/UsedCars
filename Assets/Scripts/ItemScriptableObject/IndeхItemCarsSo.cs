using UnityEngine;

namespace ItemScriptableObject
{
    [CreateAssetMenu(fileName = "IndeхItemCarsSO", menuName = "ScriptableObject/Button/IndeхItemCars", order = 0)]
    public class IndeхItemCarsSo : ScriptableObject
    {
        [SerializeField]public int Index = 0;
        
    }
}