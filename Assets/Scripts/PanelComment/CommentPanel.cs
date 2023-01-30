using System;
using ComponentSearch;
using GlobalEvent;
using ItemScriptableObject;
using TMPro;
using UnityEngine;

namespace PanelComment
{
    public class CommentPanel : MonoBehaviour
    {
        [SerializeField] private PersonName _personName;
        [SerializeField] private TMP_InputField _textComment;
        [SerializeField] private GameObject _panelComment;
        private string _pathObject;
        private string _textCommentOld;
        private void Start()
        {
            _pathObject = GetComponentInParent<ItemButtonCanvasListAuto>().pathObject;
            _textCommentOld = GetComponentInParent<ItemButtonCanvasListAuto>().GetComponentInChildren<Comment>()
                    .GetComponent<TMP_Text>().text
                ;            print(_textCommentOld);

        }

        public void Click()
        {
            if (_textCommentOld == String.Empty)
            {
                GlobalEventManager.AddComment.Invoke(_pathObject,_personName.name + ": " +_textComment.text + "\n");
            }
            else
            {
                GlobalEventManager.AddComment.Invoke(_pathObject,_textCommentOld + "\n" + _personName.name + ": " +_textComment.text);
            }
           
            _textComment.text = String.Empty;
            _panelComment.SetActive(false);
        }
    }
}