using System;
using GlobalEvent;
using TMPro;
using UnityEngine;

namespace ComponentSearch
{
    public class ItemButtonCanvasListAuto : MonoBehaviour
    {
        [SerializeField] private GameObject _panelComment;
        [SerializeField] private GameObject _questionPanel;
        
        public string pathObject = String.Empty;
        private GameObject instantiatePanelComent;
        private GameObject instantiatePanelQuestion;
        private void Start()
        {
            instantiatePanelComent = Instantiate(_panelComment, gameObject.transform);
            instantiatePanelComent.gameObject.SetActive(false);
            instantiatePanelQuestion = Instantiate(_questionPanel, gameObject.transform);
            instantiatePanelQuestion.gameObject.SetActive(false);
        }

        public void Click()
        {
            GlobalEventManager.RemoveObject.Invoke(pathObject); 
            //instantiatePanelQuestion.gameObject.SetActive(false);
        }
        
        public void OnPanelComent()
        {
            instantiatePanelComent.gameObject.SetActive(true);
        }

        public void OnPanelQuestion()
        {
            instantiatePanelQuestion.gameObject.SetActive(true);
        }
    }
}