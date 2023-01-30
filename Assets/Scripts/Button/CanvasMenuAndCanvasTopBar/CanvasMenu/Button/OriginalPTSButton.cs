using Button.CanvasMenuAndCanvasTopBar.CanvasMenu.Button.AbstractClass;
using GlobalEvent;

namespace Button.CanvasMenuAndCanvasTopBar.CanvasMenu.Button
{
    public class OriginalPTSButton : itemButton
    {
        protected override void Start()
        {
            base.Start();
            
            GlobalEventManager.DataTransmissionButtonOriginalPTS.AddListener(SetName);
        }

        public void Click()
        {
            ShowCanvasEnterData(GlobalVariable.GlobalVariable.StateButton = StateButton.OriginalPTS);
        }
    }
}