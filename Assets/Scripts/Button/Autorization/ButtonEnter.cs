using System;
using ItemScriptableObject;
using TMPro;
using UnityEngine;

namespace Button.Autorization
{
    public class ButtonEnter : MonoBehaviour
    {
        [SerializeField] private PersonName _personName;
        [SerializeField] private GameObject _canvasMenuAndCanvas;
        [SerializeField] private GameObject _canvasAutorization;
        [SerializeField] private TMP_InputField _inputField;

        private void Start()
        {
            if (_personName.name != String.Empty)
            {
                _canvasMenuAndCanvas.SetActive(true);
                _canvasAutorization.SetActive(false);
            }
        }

        public void Click()
        {
            _personName.name = _inputField.text;
            _canvasMenuAndCanvas.SetActive(true);
            _canvasAutorization.SetActive(false);
        }
    }
}