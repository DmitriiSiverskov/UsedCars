using Button.CanvasMenuAndCanvasTopBar.CanvasMenu.Button.AbstractClass;
using GlobalEvent;

namespace Button.CanvasMenuAndCanvasTopBar.CanvasMenu.Button
{
    public class StatusButton : itemButton
    {
        protected override void Start()
        {
            base.Start();
            
            GlobalEventManager.DataTransmissionButtonStatus.AddListener(SetName);
        }

        public void Click()
        {
            ShowCanvasEnterData(GlobalVariable.GlobalVariable.StateButton = StateButton.Status);
        }
    }
}