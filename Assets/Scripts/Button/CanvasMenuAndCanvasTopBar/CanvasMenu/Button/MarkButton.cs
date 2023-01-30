using Button.CanvasMenuAndCanvasTopBar.CanvasMenu.Button.AbstractClass;
using GlobalEvent;

namespace Button.CanvasMenuAndCanvasTopBar.CanvasMenu.Button
{
    public class MarkButton : itemButton
    {
        protected override void Start()
        {
            base.Start();
            
                GlobalEventManager.DataTransmissionButtonMark.AddListener(SetName);
        }

        public void Click()
        {
            ShowCanvasEnterData(GlobalVariable.GlobalVariable.StateButton = StateButton.MarkButton);
        }
    }
}