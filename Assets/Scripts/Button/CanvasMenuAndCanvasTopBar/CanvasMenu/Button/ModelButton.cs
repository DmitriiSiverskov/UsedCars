using Button.CanvasMenuAndCanvasTopBar.CanvasMenu.Button.AbstractClass;
using GlobalEvent;

namespace Button.CanvasMenuAndCanvasTopBar.CanvasMenu.Button
{
    public class ModelButton : itemButton
    {
        protected override void Start()
        {
            base.Start();
            GlobalEventManager.DataTransmissionButtonModel.AddListener(SetName);
        }

        public void Click()
        {
            ShowCanvasEnterData(GlobalVariable.GlobalVariable.StateButton = StateButton.ModelButton);
        }
    }
}