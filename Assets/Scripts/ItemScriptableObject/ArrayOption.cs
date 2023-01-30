using UnityEngine;

namespace ItemScriptableObject
{
    [CreateAssetMenu(fileName = "ArrayOption", menuName = "ScriptableObject/Button/ArrayOptionSO")]
    public class ArrayOption : ScriptableObject
    {
        [SerializeField] private string[] _option;
        public string[] Option => _option;
    }
}