using TMPro;
using UnityEngine;

namespace Button.CanvasMenuAndCanvasTopBar.CanvasTopBar.CanvasOwner.AbstractClass
{
    public abstract class UIInputProcessing : MonoBehaviour
    {
        [SerializeField] protected TMP_InputField _inputField;
        [SerializeField] protected int _lenghtStr;

        private void Update()
        {
            TransferText();
        }

        public void TransferText()
        {
            if (_inputField.text.Length > _lenghtStr)
            {
                var str = _inputField.text.Remove(_lenghtStr, 1);
                _inputField.text = str;
                
            }
        }
    }
}