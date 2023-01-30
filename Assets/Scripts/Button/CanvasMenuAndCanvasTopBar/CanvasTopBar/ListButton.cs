using Button.AutorizationAndRegistration;
using Button.CanvasMenuAndCanvasTopBar.CanvasTopBar.AbstractClass;
using GlobalEvent;
using GlobalVariable;
using UnityEngine;

namespace Button.CanvasMenuAndCanvasTopBar.CanvasTopBar
{
    public class ListButton : OpenCloseWindowsInformation
    {
        [SerializeField] private DB _db;
        
        public void Click()
        {
            GlobalVariable.GlobalVariable.StateCanvasTopBar = StataCanvasTopBar.List;
            GlobalEventManager.DataTransmissionStateCanvasTopBar.Invoke();
            StartCoroutine(_db.LoadData());
        }

        protected override void ShowCanvas()
        {
            if (GlobalVariable.GlobalVariable.StateCanvasTopBar == StataCanvasTopBar.List)
            {
                _canvasMenu.gameObject.SetActive(true);
                _imageColor.color = Color.green;
            }
            else
            {
                _canvasMenu.gameObject.SetActive(false);
                _imageColor.color = _colors[0].color;
            }
        }
    }
}