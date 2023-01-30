using System;
using System.Collections.Generic;
using Button.AutorizationAndRegistration;
using ClassCar;
using ComponentSearch;
using TMPro;
using UnityEngine;

namespace Button.CanvasMenuAndCanvasTopBar.CanvasMenu
{
    public class SaveInformationCanvasOwner : MonoBehaviour
    {
        [SerializeField] private DB _db;
        [SerializeField] private PanelMassege _panelMassege;
        [SerializeField] private TMP_InputField _lastName;
        [SerializeField] private TMP_InputField _firstName;
        [SerializeField] private TMP_InputField _middleName;
        [SerializeField] private TMP_InputField _seriesAndNumber;
        [SerializeField] private TMP_InputField _issuedByWhom;
        [SerializeField] private TMP_InputField _registration;
        [SerializeField] private TMP_InputField _numberPhone;
        [SerializeField] private TMP_InputField _registrationDate;
        private List<TMP_InputField> _listInputField = new List<TMP_InputField>();
        
         public void SaveInfo()
        {
            if (_lastName.text.Length > 0)
            {
                GlobalVariable.GlobalVariable.VariableNameLastName = _lastName.text;
                AddListInputField(_lastName);
            }
            if (_firstName.text.Length > 0)
            {
                GlobalVariable.GlobalVariable.VariableNameFirstName = _firstName.text;
                AddListInputField(_firstName);
            }
            if (_middleName.text.Length > 0)
            {
                GlobalVariable.GlobalVariable.VariableNameMiddleName = _middleName.text;
                AddListInputField(_middleName);
            }
            if (_seriesAndNumber.text.Length > 0)
            {
                GlobalVariable.GlobalVariable.VariableNameSeriesAndNumber = _seriesAndNumber.text;
                AddListInputField(_seriesAndNumber);
            }
            if (_issuedByWhom.text.Length > 0)
            {
                GlobalVariable.GlobalVariable.VariableNameIssuedByWhom = _issuedByWhom.text;
                AddListInputField(_issuedByWhom);
            }
            if (_registration.text.Length > 0)
            {
                GlobalVariable.GlobalVariable.VariableNameRegistration = _registration.text;
                AddListInputField(_registration);
            }
            if (_numberPhone.text.Length > 0)
            {
                GlobalVariable.GlobalVariable.VariableNameNumberPhone = _numberPhone.text;
                AddListInputField(_numberPhone);
            }
            if (_registrationDate.text.Length > 0)
            {
                GlobalVariable.GlobalVariable.VariableNameRegistrationDate = _registrationDate.text;
                AddListInputField(_registrationDate);
            }
            
            ClearInputField(_listInputField);
            ShowPanelMassega();
            Car car = new Car(
                GlobalVariable.GlobalVariable.VariableNameMark,
                GlobalVariable.GlobalVariable.VariableNameModel,
                GlobalVariable.GlobalVariable.VariableNameGeneration,
                GlobalVariable.GlobalVariable.VariableNameModification,
                GlobalVariable.GlobalVariable.VariableNameBodyType,
                GlobalVariable.GlobalVariable.VariableNameDrive,
                GlobalVariable.GlobalVariable.VariableNameFielGrade,
                GlobalVariable.GlobalVariable.VariableNameVin,
                GlobalVariable.GlobalVariable.VariableNameRun,
                GlobalVariable.GlobalVariable.VariableNameYear,
                GlobalVariable.GlobalVariable.VariableNameRegistrationPlate,
                GlobalVariable.GlobalVariable.VariableNameColorCar,
                GlobalVariable.GlobalVariable.VariableNameStatus,
                GlobalVariable.GlobalVariable.VariableNameNumberOfOwner,
                GlobalVariable.GlobalVariable.VariableNameNumberPTS,
                GlobalVariable.GlobalVariable.VariableNameNumberCPTS,
                GlobalVariable.GlobalVariable.VariableNameNumberDVS,
                GlobalVariable.GlobalVariable.VariableNameOriginalPTS,
                GlobalVariable.GlobalVariable.VariableNamePrice,
                GlobalVariable.GlobalVariable.VariableNameLastName,
                GlobalVariable.GlobalVariable.VariableNameFirstName,
                GlobalVariable.GlobalVariable.VariableNameMiddleName,
                GlobalVariable.GlobalVariable.VariableNameSeriesAndNumber,
                GlobalVariable.GlobalVariable.VariableNameIssuedByWhom,
                GlobalVariable.GlobalVariable.VariableNameRegistration,
                GlobalVariable.GlobalVariable.VariableNameNumberPhone,
                GlobalVariable.GlobalVariable.VariableNameRegistrationDate,
                GlobalVariable.GlobalVariable.VariableNameComent);
            _db.SaveData(car);
        }

        private void AddListInputField(TMP_InputField inputField)
        {
            _listInputField.Add(inputField);
        }

        private void ClearInputField(List<TMP_InputField> arrStr)
        {
            for (int i = 0; i < arrStr.Count; i++)
            {
                arrStr[i].text = String.Empty;
            }
        }

        private void ShowPanelMassega()
        {
            _panelMassege.gameObject.SetActive(true);
        }
    }
}
