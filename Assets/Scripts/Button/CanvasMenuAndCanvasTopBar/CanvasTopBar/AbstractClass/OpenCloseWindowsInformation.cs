using ComponentSearch;
using GlobalEvent;
using UnityEngine;
using Image = UnityEngine.UI.Image;

namespace Button.CanvasMenuAndCanvasTopBar.CanvasTopBar.AbstractClass
{
    
    public abstract class OpenCloseWindowsInformation : MonoBehaviour
    {
        [SerializeField] protected WindowsCanvasMenu _canvasMenu;
        [SerializeField] protected Image _imageColor;
        [SerializeField] protected Material[] _colors;

        protected virtual void Start()
        {
            GlobalEventManager.DataTransmissionStateCanvasTopBar.AddListener(ShowCanvas);
        }

        protected virtual void ShowCanvas() { }
        
    }
}