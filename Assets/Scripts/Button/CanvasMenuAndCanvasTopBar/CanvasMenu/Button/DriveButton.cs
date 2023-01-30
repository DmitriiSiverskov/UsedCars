using Button.CanvasMenuAndCanvasTopBar.CanvasMenu.Button.AbstractClass;
using GlobalEvent;

namespace Button.CanvasMenuAndCanvasTopBar.CanvasMenu.Button
{
    public class DriveButton : itemButton
    {
        protected override void Start()
        {
            base.Start();
            
            GlobalEventManager.DataTransmissionButtonDrive.AddListener(SetName);
        }

        public void Click()
        {
            ShowCanvasEnterData(GlobalVariable.GlobalVariable.StateButton = StateButton.Drive);
        }
    }
}