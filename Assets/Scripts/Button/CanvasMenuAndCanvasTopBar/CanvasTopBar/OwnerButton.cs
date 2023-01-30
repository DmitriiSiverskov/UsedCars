using Button.CanvasMenuAndCanvasTopBar.CanvasTopBar.AbstractClass;
using GlobalEvent;
using GlobalVariable;
using UnityEngine;

namespace Button.CanvasMenuAndCanvasTopBar.CanvasTopBar
{
    public class OwnerButton : OpenCloseWindowsInformation
    {
        public void Click()
        {
            GlobalVariable.GlobalVariable.StateCanvasTopBar = StataCanvasTopBar.Owner;
            GlobalEventManager.DataTransmissionStateCanvasTopBar.Invoke();
        }
        protected override void ShowCanvas()
        {
            if (GlobalVariable.GlobalVariable.StateCanvasTopBar == StataCanvasTopBar.Owner)
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