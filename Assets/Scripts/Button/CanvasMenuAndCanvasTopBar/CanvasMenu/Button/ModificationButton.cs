using Button.CanvasMenuAndCanvasTopBar.CanvasMenu.Button.AbstractClass;
using GlobalEvent;

namespace Button.CanvasMenuAndCanvasTopBar.CanvasMenu.Button
{
    public class ModificationButton : itemButton
    {
        protected override void Start()
        {
            base.Start();
            GlobalEventManager.DataTransmissionButtonModification.AddListener(SetName);
        }

        public void Click()
        {
            ShowCanvasEnterData(GlobalVariable.GlobalVariable.StateButton = StateButton.ModificationButton);
        }
    }
}