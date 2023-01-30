using System;
using GlobalEvent;
using TMPro;
using UnityEngine;

namespace Button.CanvasMenuAndCanvasTopBar.CanvasMenu
{
    public class SetTextBodyType : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _textBodyType;
        private void Start()
        {
            GlobalEventManager.DataTransmissionButtonGeneration.AddListener(SetText);
        }

        private void SetText(string str)
        {
            string newstr = String.Empty;
            foreach (var item in str)
            {
                if (item != ' ')
                {
                    newstr += item;
                }
                else
                {
                    _textBodyType.text = newstr;
                    GlobalVariable.GlobalVariable.VariableNameBodyType = newstr;
                    return;
                }
            }
        }
    }
}