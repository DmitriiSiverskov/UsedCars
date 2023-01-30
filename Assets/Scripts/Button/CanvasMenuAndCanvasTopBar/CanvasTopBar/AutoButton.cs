using Button.CanvasMenuAndCanvasTopBar.CanvasTopBar.AbstractClass;
using GlobalEvent;
using GlobalVariable;
using UnityEngine;

namespace Button.CanvasMenuAndCanvasTopBar.CanvasTopBar
{
    public class AutoButton : OpenCloseWindowsInformation
    {
        public void Click()
        {
            GlobalVariable.GlobalVariable.StateCanvasTopBar = StataCanvasTopBar.Auto;
            GlobalEventManager.DataTransmissionStateCanvasTopBar.Invoke();
        }

        protected override void ShowCanvas()
        {
            if (GlobalVariable.GlobalVariable.StateCanvasTopBar == StataCanvasTopBar.Auto)
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