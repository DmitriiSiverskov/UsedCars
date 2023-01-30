using System;
using System.Collections.Generic;
using ComponentSearch;
using TMPro;
using UnityEngine;

namespace Button.CanvasMenuAndCanvasTopBar.CanvasMenu
{
    public class SaveInformationCanvasMenu : MonoBehaviour
    {
        [SerializeField] private PanelMassege _panelMassege;
        [SerializeField] private ButtonOnActive[] _inputFieldButton;
        [SerializeField] private TMP_Text _textBodyType;
        [SerializeField] private TMP_InputField _inputVIN;
        [SerializeField] private TMP_InputField _inputRun;
        [SerializeField] private TMP_InputField _inputYear;
        [SerializeField] private TMP_InputField _inputRegistrationPlate;
        [SerializeField] private TMP_InputField _inputColorCar;
        [SerializeField] private TMP_InputField _inputNumberOfOwners;
        [SerializeField] private TMP_InputField _inputNumberPTS;
        [SerializeField] private TMP_InputField _inputNumberCPTS;
        [SerializeField] private TMP_InputField _inputNumberDVS;
        [SerializeField] private TMP_InputField _inputNumberPrice;
        private List<TMP_InputField> _listInputField = new List<TMP_InputField>();

        public void SaveInfo()
        {
            if (_inputVIN.text.Length > 0)
            {
                GlobalVariable.GlobalVariable.VariableNameVin = _inputVIN.text;
                AddListInputField(_inputVIN);
            }
            if (_inputRun.text.Length > 0)
            {
                GlobalVariable.GlobalVariable.VariableNameRun = _inputRun.text;
                AddListInputField(_inputRun);
            }
            if (_inputYear.text.Length > 0)
            {
                GlobalVariable.GlobalVariable.VariableNameYear = _inputYear.text;
                AddListInputField(_inputYear);
            }
            if (_inputRegistrationPlate.text.Length > 0)
            {
                GlobalVariable.GlobalVariable.VariableNameRegistrationPlate = _inputRegistrationPlate.text;
                AddListInputField(_inputRegistrationPlate);
            }
            if (_inputColorCar.text.Length > 0)
            {
                GlobalVariable.GlobalVariable.VariableNameColorCar = _inputColorCar.text;
                AddListInputField(_inputColorCar);
            }
            if (_inputNumberOfOwners.text.Length > 0)
            {
                GlobalVariable.GlobalVariable.VariableNameNumberOfOwner = _inputNumberOfOwners.text;
                AddListInputField(_inputNumberOfOwners);
            }
            if (_inputNumberPTS.text.Length > 0)
            {
                GlobalVariable.GlobalVariable.VariableNameNumberPTS = _inputNumberPTS.text;
                AddListInputField(_inputNumberPTS);
            }
            if (_inputNumberCPTS.text.Length > 0)
            {
                GlobalVariable.GlobalVariable.VariableNameNumberCPTS = _inputNumberCPTS.text;
                AddListInputField(_inputNumberCPTS);
            }
            if (_inputNumberDVS.text.Length > 0)
            {
                GlobalVariable.GlobalVariable.VariableNameNumberDVS = _inputNumberDVS.text;
                AddListInputField(_inputNumberDVS);
            }
            if (_inputNumberPrice.text.Length > 0)
            {
                GlobalVariable.GlobalVariable.VariableNamePrice = _inputNumberPrice.text;
                AddListInputField(_inputNumberPrice);
            }
            ClearInputField(_listInputField);
            ClearButtonText(_inputFieldButton);
            ShowPanelMassega();
        }

        private void AddListInputField(TMP_InputField inputField)
        {
            _listInputField.Add(inputField);
        }

        private void ClearInputField(List<TMP_InputField> arrStr)
        {
            _textBodyType.text = String.Empty;
            for (int i = 0; i < arrStr.Count; i++)
            {
                arrStr[i].text = String.Empty;
            }
        }

        private void ClearButtonText(ButtonOnActive[] arrButton)
        {
            for (int i = 0; i < arrButton.Length; i++)
            {
                if (i == 0)
                {
                    arrButton[i].GetComponentInChildren<TMP_Text>().text = "Выбрать";
                    arrButton[i].GetComponentInChildren<TMP_Text>().color = Color.green;
                }
                else
                {
                    arrButton[i].GetComponentInChildren<TMP_Text>().text = "Выбрать";
                    arrButton[i].GetComponentInChildren<TMP_Text>().color = Color.green;
                    arrButton[i].gameObject.SetActive(false);
                }
            }
        }

        private void ShowPanelMassega()
        {
            _panelMassege.gameObject.SetActive(true);
        }
    }
}