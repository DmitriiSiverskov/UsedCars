using System;
using UnityEngine;

namespace ItemScriptableObject
{
    [CreateAssetMenu(fileName = "PersonName", menuName = "ScriptableObject/Person/PersonName")]
    public class PersonName : ScriptableObject
    {
        public string name = String.Empty;
    }
}