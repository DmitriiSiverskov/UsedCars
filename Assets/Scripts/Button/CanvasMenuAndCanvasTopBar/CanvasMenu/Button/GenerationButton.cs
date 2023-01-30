using Button.CanvasMenuAndCanvasTopBar.CanvasMenu.Button.AbstractClass;
using GlobalEvent;

namespace Button.CanvasMenuAndCanvasTopBar.CanvasMenu.Button
{
    public class GenerationButton : itemButton
    {
      
        protected override void Start()
        {
            base.Start();
            GlobalEventManager.DataTransmissionButtonGeneration.AddListener(SetName);
        }

        public void Click()
        {
            ShowCanvasEnterData(GlobalVariable.GlobalVariable.StateButton = StateButton.GenerationButton);
        }
    }
}