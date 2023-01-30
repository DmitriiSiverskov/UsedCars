using System;
using System.Collections.Generic;
using ComponentSearch;
using GlobalEvent;
using ItemScriptableObject;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

namespace Button.CanvasMenuAndCanvasTopBar.CanvasMenu.Button.AbstractClass
{
    public enum StateButton
    {
        MarkButton,
        GenerationButton,
        ModelButton,
        ModificationButton,
        Drive,
        FielGrade,
        Status,
        OriginalPTS
    }
    public abstract class itemButton : MonoBehaviour
    {
        [FormerlySerializedAs("_arrayItemCarsSo")] [SerializeField] private ArrayItem arrayItem;
        [SerializeField] private ArrayOption _arrayOption;
        [SerializeField] private CanvasEnterData _canvasEnterData;
        [SerializeField] private ContentCanvasEnterData _content;
        [SerializeField] private ItemButtonCanvasEnterData _itemButtonCanvasEnterData;
        [SerializeField] protected ButtonOnActive _buttonActive;
        private List<GameObject> _arrayItemButton = new List<GameObject>();
        
        protected virtual void Start()
        {
            GlobalEventManager.ActiveCanvasEnterData.AddListener(ClearArrayItemButton);
            GlobalEventManager.DataTransmissionButtonMark.AddListener(SetStrigInVariableNameMark);
            GlobalEventManager.DataTransmissionButtonModel.AddListener(SetStrigInVariableNameModel);
            GlobalEventManager.DataTransmissionButtonGeneration.AddListener(SetStrigInVariableNameGeneration);
            GlobalEventManager.DataTransmissionButtonModification.AddListener(SetStrigInVariableNameModification);
            GlobalEventManager.DataTransmissionButtonDrive.AddListener(SetStrigInVariableNameDrive);
            GlobalEventManager.DataTransmissionButtonFuelGrade.AddListener(SetStrigInVariableNameFielGrade);
            GlobalEventManager.DataTransmissionButtonStatus.AddListener(SetStrigInVariableNameStatus);
            GlobalEventManager.DataTransmissionButtonOriginalPTS.AddListener(SetStrigInVariableNameOriginalPTS);
        }
        protected void ShowCanvasEnterData(StateButton stateButton)
        {
            _canvasEnterData.gameObject.SetActive(true);
            if (stateButton == StateButton.MarkButton)
            {
                foreach (var item in arrayItem.ItemCars)
                {
                    _itemButtonCanvasEnterData.GetComponentInChildren<TextMeshProUGUI>().text = item.name;
                    var instantiate = Instantiate(_itemButtonCanvasEnterData, _content.transform);
                    SetArrayItemButton(instantiate.gameObject);
                }
            }
            else if (stateButton == StateButton.ModelButton)
            {
                foreach (var item in arrayItem.ItemCars)
                {
                    if (string.Equals(item.name, GlobalVariable.GlobalVariable.VariableNameMark,
                        StringComparison.Ordinal))
                    {
                        foreach (var itemG in item.Model.Model)
                        {
                            _itemButtonCanvasEnterData.GetComponentInChildren<TextMeshProUGUI>().text = itemG;
                            var instantiate = Instantiate(_itemButtonCanvasEnterData, _content.transform);
                            SetArrayItemButton(instantiate.gameObject);
                        }
                        return;
                    }
                }
            }
            else if (stateButton == StateButton.GenerationButton)
            {
                foreach (var item in arrayItem.ItemCars)
                {
                    if (string.Equals(item.name, GlobalVariable.GlobalVariable.VariableNameMark,
                        StringComparison.Ordinal))
                    {
                        foreach (var itemG in item.Generation.Generation)
                        {
                            if (string.Equals(itemG.name, GlobalVariable.GlobalVariable.VariableNameModel,
                                StringComparison.Ordinal))
                            {
                                foreach (var itemGM in itemG.GenerationModification)
                                {
                                    _itemButtonCanvasEnterData.GetComponentInChildren<TextMeshProUGUI>().text = itemGM;
                                    var instantiate = Instantiate(_itemButtonCanvasEnterData, _content.transform);
                                    SetArrayItemButton(instantiate.gameObject);
                                }
                            }
                        }
                        return;
                    }
                }
            }
            else if (stateButton == StateButton.ModificationButton)
            {
                foreach (var item in arrayItem.ItemCars)
                {
                    if (string.Equals(item.name, GlobalVariable.GlobalVariable.VariableNameMark,
                        StringComparison.Ordinal))
                    {
                        foreach (var itemM in item.Modification)
                        {
                            if (string.Equals(itemM.name, GlobalVariable.GlobalVariable.VariableNameGeneration,
                                StringComparison.Ordinal))
                            {
                                foreach (var itemMG in itemM.Modification)
                                {
                                    _itemButtonCanvasEnterData.GetComponentInChildren<TextMeshProUGUI>().text = itemMG;
                                    var instantiate = Instantiate(_itemButtonCanvasEnterData, _content.transform);
                                    SetArrayItemButton(instantiate.gameObject);
                                }
                            }
                        }
                        return;
                    }
                }
            }
            else  if (stateButton == StateButton.Drive || stateButton == StateButton.FielGrade
                                                       || stateButton == StateButton.Status
                                                       || stateButton == StateButton.OriginalPTS)
            {
                foreach (var item in _arrayOption.Option)
                {
                    _itemButtonCanvasEnterData.GetComponentInChildren<TextMeshProUGUI>().text = item;
                    var instantiate = Instantiate(_itemButtonCanvasEnterData, _content.transform);
                    SetArrayItemButton(instantiate.gameObject);
                }
            }
        }
        protected void SetName(string str)
        {
            gameObject.GetComponentInChildren<TextMeshProUGUI>().text = str;
            if (gameObject.GetComponentInChildren<TextMeshProUGUI>().text != "Выбрать")
            {
                gameObject.GetComponentInChildren<TextMeshProUGUI>().color = Color.black;
                if (GlobalVariable.GlobalVariable.StateButton != StateButton.OriginalPTS)
                {
                    _buttonActive.gameObject.SetActive(true);
                }
            }
        }

        private void SetArrayItemButton(GameObject gameObject)
        {
            _arrayItemButton.Add(gameObject);
        }

        private void ClearArrayItemButton(bool b)
        {
            foreach (var item in _arrayItemButton)
            {
                Destroy(item);
            }
            _canvasEnterData.gameObject.SetActive(b);
        }

        private void SetStrigInVariableNameMark(string str)
        {
            GlobalVariable.GlobalVariable.VariableNameMark = str;
        }
        private void SetStrigInVariableNameModel(string str)
        {
            GlobalVariable.GlobalVariable.VariableNameModel = str;
        }
        private void SetStrigInVariableNameGeneration(string str)
        {
            GlobalVariable.GlobalVariable.VariableNameGeneration = str;
        }
        private void SetStrigInVariableNameModification(string str)
        {
            GlobalVariable.GlobalVariable.VariableNameModification = str;
        }
        private void SetStrigInVariableNameDrive(string str)
        {
            GlobalVariable.GlobalVariable.VariableNameDrive = str;
        }
        private void SetStrigInVariableNameFielGrade(string str)
        {
            GlobalVariable.GlobalVariable.VariableNameFielGrade = str;
        }
        private void SetStrigInVariableNameStatus(string str)
        {
            GlobalVariable.GlobalVariable.VariableNameStatus = str;
        }
        private void SetStrigInVariableNameOriginalPTS(string str)
        {
            GlobalVariable.GlobalVariable.VariableNameOriginalPTS = str;
        }
     }
}